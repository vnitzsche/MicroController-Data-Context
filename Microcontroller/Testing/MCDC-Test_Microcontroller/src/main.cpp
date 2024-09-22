#include <Arduino.h>
EspClass esp;
void setup() {
  Serial.begin(115200);
}

void loop() {
  Serial.print(esp.getChipRevision());
}