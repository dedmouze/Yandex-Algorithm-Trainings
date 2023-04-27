using System;

const int SecondsInMinute = 60;
const int SecondsInHour = SecondsInMinute * 60;
const int SecondsInDay = SecondsInHour * 24;

string sA = "0:" + Console.ReadLine();
string sB = "1:" + Console.ReadLine();
string sC = "1:" + Console.ReadLine();

TimeSpan A = TimeSpan.Parse(sA);
TimeSpan B = TimeSpan.Parse(sB);
TimeSpan C = TimeSpan.Parse(sC);

double sendRespondTime = (C.TotalSeconds - A.TotalSeconds) % SecondsInDay;
double sendTime = (sendRespondTime / 2 + sendRespondTime % 2);

int resultTimeInSeconds = (int)(B.TotalSeconds + sendTime);

int hour = (resultTimeInSeconds / SecondsInHour) % 24;
resultTimeInSeconds %= SecondsInHour;
int minute = resultTimeInSeconds / SecondsInMinute;
resultTimeInSeconds %= SecondsInMinute;

TimeSpan result = new TimeSpan(hour, minute, resultTimeInSeconds);

Console.WriteLine(result);