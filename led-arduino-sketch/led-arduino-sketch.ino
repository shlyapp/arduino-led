#include <GParser.h>
#include "EEPROM.h"

#define R_PIN 9
#define G_PIN 10
#define B_PIN 11

///////////////////////////////////////////////////////////////////////////////

byte rgb[3];
byte last_rgb[3] = {0, 0, 0};

// счетчик для задержек
unsigned long int current_millis;

char mode = 'a';
// скорость изменения цветов палитры
int speed_change = 20;

const byte array_size = 3;
byte colors[array_size][3] = 
{
  {255, 0, 0},
  {0, 255, 0},
  {0, 0, 255},
};
int speed_change_colors = 20;
int speed_change_rainbow = 20;
byte colors_rainbow[7][3] = 
{
  {255, 0, 0},
  {255, 127, 0},
  {255, 255, 0},
  {0, 255, 0},
  {255, 0, 255},
  {75, 0, 130},
  {143, 0, 255}
};

byte this_color_rainbow = -1;
byte this_color = -1;

///////////////////////////////////////////////////////////////////////////////

void setup()
{
  // установка пинов
  pinMode(R_PIN, OUTPUT);
  pinMode(G_PIN, OUTPUT);
  pinMode(B_PIN, OUTPUT);

  analogWrite(R_PIN, 0);
  analogWrite(G_PIN, 0);
  analogWrite(B_PIN, 0);
   
  // установка значение для порта
  Serial.begin(500000);
  Serial.setTimeout(5);

  // считавание данных из памяти
  rgb[0] = EEPROM[0];
  rgb[1] = EEPROM[1];
  rgb[2] = EEPROM[2];
}

///////////////////////////////////////////////////////////////////////////////

// плавная смена цвета
void smoothColorChange(int speed_smooth)
{
  if (millis() - current_millis > speed_smooth)
  {
    current_millis = millis();
    for (int i = 0; i < 3; i++)
    {
      if (rgb[i] > last_rgb[i])
      {
        last_rgb[i]++;
      }
      if (rgb[i] < last_rgb[i])
      {
        last_rgb[i]--;
      }
        
      analogWrite(9 + i, last_rgb[i]);
    }
  }
}

///////////////////////////////////////////////////////////////////////////////

void changeColor()
{
  analogWrite(R_PIN, rgb[0]);
  analogWrite(G_PIN, rgb[1]);
  analogWrite(B_PIN, rgb[2]);
}

///////////////////////////////////////////////////////////////////////////////

bool equalsRGB()
{
  bool flag = true;

  for (int i = 0; i < 3; i++)
  {
    if(rgb[i] != last_rgb[i])
    {
      flag = false;
    }
  }

  return flag;
}

///////////////////////////////////////////////////////////////////////////////

void effectSmoothChangeColor()
{
  if (equalsRGB())
  {
    this_color++;
    if (this_color < array_size)
    {
      for (int i = 0; i < 3; i++) rgb[i] = colors[this_color][i];
      smoothColorChange(speed_change_colors);
    }
    else
    {
      this_color = -1;
      effectSmoothChangeColor();
    }
  }
  else
  {
    smoothColorChange(speed_change_colors);
  }
}

///////////////////////////////////////////////////////////////////////////////

void effectRainbow()
{
  if (equalsRGB())
  {
    this_color_rainbow++;
    if (this_color_rainbow < 7)
    {
      for (int i = 0; i < 3; i++) rgb[i] = colors_rainbow[this_color][i];
      smoothColorChange(speed_change_rainbow);
    }
    else
    {
      this_color_rainbow = -1;
      effectSmoothChangeColor();
    }
  }
  else
  {
    smoothColorChange(speed_change_rainbow);
  }
}

///////////////////////////////////////////////////////////////////////////////

void saveData()
{
  EEPROM.update(0, rgb[0]);
  EEPROM.update(1, rgb[1]);
  EEPROM.update(2, rgb[2]);
}

///////////////////////////////////////////////////////////////////////////////
void loop()
{
  // парсинг данных
  if (Serial.available())
  {
    char str[30];
    int amount = Serial.readBytesUntil(';', str, 150);
    str[amount] = NULL;

    GParser data(str, ',');
    int ints[10];
    int am = data.parseInts(ints);
    
    // установка значений и выбор режима
    switch(ints[0])
    {
      // установка цвета
      case 0:
        for (int i = 1; i < am; i++) rgb[i - 1] = ints[i];
        mode = 'a';
        break;
      case 1:
        for (int i = 1; i < am; i++) rgb[i - 1] = ints[i];
        mode = 'b';
        break;
      case 2:
        for (int i = 0; i < 3; i++) rgb[i] = 0;
        mode = 'a';
        break;
      case 3:
        speed_change = ints[1];
        break;
      case 4:
        saveData();
        break;
      case 5:
        mode = 'c';
        speed_change_colors = ints[1];
        break;
      case 6:
        mode = 'd';
        speed_change_rainbow = ints[1];
        break; 
    }
  }

  // режимы свечения
  switch(mode)
  {
    case 'a':
      smoothColorChange(speed_change);
      break;
    case 'b':
      changeColor();
      break;
    case 'c':
      effectSmoothChangeColor();
      break;
    case 'd':
      effectRainbow();
      break;
  }
  
}
