#define R 10
#define G 9
#define B 11

byte r_;
byte g_;
byte b_;

unsigned long int current_millis;
int value_led;
int serial_val;
bool raising = true;

char key;
int mode;

void setup() {
  pinMode(R, OUTPUT);
  pinMode(G, OUTPUT);
  pinMode(B, OUTPUT);

  analogWrite(R, 0);
  analogWrite(G, 0);
  analogWrite(B, 0);
  
  Serial.begin(9600);
  Serial.setTimeout(5);

}

void smoothFlashing(int speed)
{
  if (millis() - current_millis > speed)
  {
    current_millis = millis();
    if (raising) 
      value_led++;
    else
      value_led--;
    if (value_led >= 255 || value_led <= 0) raising = !raising;
    analogWrite(R, value_led);
    analogWrite(B, value_led);
    Serial.println(value_led);
  }
}

void loop() {
  if (Serial.available() > 1)
  {
    key = Serial.read();
    serial_val = 255 - Serial.parseInt();
    switch (key)
    {
      case 'r':
        r_ = serial_val;
        analogWrite(R, r_);
        break;
      case 'g':
        g_ = serial_val;
        analogWrite(G, g_);
        break;
      case 'b':
        b_ = serial_val;
        analogWrite(B, b_);
        break;
    }
  }

  switch (key)
  {
    case 'e':
      smoothFlashing(serial_val / 100);
      break;
  }
}
