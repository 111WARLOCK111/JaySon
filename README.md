JaySon
======

JaySon Is a config system / Lib for C#, It Is a simple config system which is easy to read and edit.
You can only write strings into a JaySon file, For numbers or any type of object, Parse the string to get the object.


Examples
========

```C#
string user = "MySelf";
string pass = "MyPass";
string help = "There's no need for any help!";

Serializer.Serialize(user + "/" + pass + "/" + help, "username/password/comments", "testconfig.txt");

string[] getall = Deserializer.Deserialize("username/password/comments", "testconfig.txt");

Console.WriteLine(getall[0]);
// Output: MySelf
Console.WriteLine(getall[1]);
// Output: MyPass
Console.WriteLine(getall[2]);
// Output: There's no need for any help!
```