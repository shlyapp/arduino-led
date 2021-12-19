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

int key;

///////////////////////////////////////////////////////////////////////////////

void setup()
{
  // установка пинов
  pinMode(R_PIN, OUTPUT);
  pinMode(G_PIN, OUTPUT);
  pinMode(B_PIN, OUTPUT);

  // установка значение для порта
  Serial.begin(9600);
  Serial.setTimeout(5);

  // считавание данных из памяти
  rgb[0] = EEPROM[0];
  rgb[1] = EEPROM[1];
  rgb[2] = EEPROM[2];
  for (int i = 0; i < 3; i++) Serial.println(rgb[i]);
  
}

///////////////////////////////////////////////////////////////////////////////

void ledOn(int speed = 5)
{
  if (millis() - current_millis > speed)
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
  //analogWrite(R_PIN, rgb[0]);
  //analogWrite(G_PIN, rgb[1]);
  //analogWrite(B_PIN, rgb[2]);
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
    key = ints[0];
    
    // режимы
    switch(ints[0])
    {
      // установка цвета
      case 0:
        for (int i = 1; i < am; i++) rgb[i - 1] = ints[i];
        break;
    }
  }

  switch(key)
  {
    case 1:
      ledOn();
      break;
  }
  
}
