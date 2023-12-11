using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP;

// I skal ikke lave en tilfældigt klasse og implementer en Person metode, men lave
// en "person klasse" med "members" som beskriver hvad personen har af egenskaber.

internal class Class1
{
    public string Person(string name, int tlf, string email)
    {
        return $"{name} {tlf} {email}";
    }
}
