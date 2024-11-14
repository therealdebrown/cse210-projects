using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
public class Job
{
    public string _company;
    public string _JobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_company} {_JobTitle} {_startYear} {_endYear}");
    }
}