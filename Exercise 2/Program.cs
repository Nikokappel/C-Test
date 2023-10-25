// See https://aka.ms/new-console-template for more information
using Exercise_2;

TrafficLight tl = new();
new Car(tl, 1);
new Car(tl, 2);
new Taxi(tl, 1);
new Taxi(tl, 2);
new Pedestrian(tl, 1);
new Pedestrian(tl, 2);
tl.RunTrafficLight();
