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
int speed_change = 20;

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
void smoothColorChange()
{
  if (millis() - current_millis > speed_change)
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
    }
  }

  // режимы свечения
  switch(mode)
  {
    case 'a':
      smoothColorChange();
      break;
    case 'b':
      changeColor();
      break;
  }
  
}
