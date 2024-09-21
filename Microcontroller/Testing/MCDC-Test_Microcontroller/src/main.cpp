#include <Arduino.h>

void setup() {
  Serial.begin(115200);
}

void loop() {
  if(Serial.available()){
    String readString = Serial.readString();
    Serial.write("OK: Microcontroller 1");
  }
}
