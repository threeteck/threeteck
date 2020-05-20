using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Introduction
{
    public static void Main(string[] args)
    {
        Console.Title = "Introduction";
        Console.WriteLine(
@"ФИО - Загитов Артур Александрович
Дата рождения - 17.02.2001 
Группа - 11-909 
Родился в Казани, учился в гимназии №122. 
Любимый язык программирования - C#, начал на нем писать впервые в 4-ом классе. 
В шестом классе начал увлекаться олимпиадным программированием(и до сих пор увлекаюсь). 
Также я любил писать различные визуализации на Windows Forms, Unity, OpenGL(Tao Framework) 
и другие интересные мне проекты вроде интерпритатора собственного языка, движка для 3д графики и др. 
Однако с вебом никогда не работал, т.к раньше мне это было не очень интересно, 
но сейчас возникло желание попробовать, поэтому и записался на курс Django."
);
        Console.ReadKey();
    }
}
