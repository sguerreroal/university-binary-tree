using System;

namespace BynaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "Rector";
            rectorPosition.Salary = 1000;

            Position vicFinPosition = new Position();
            vicFinPosition.Name = "Vicerector Financiero";
            vicFinPosition.Salary = 750;

            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe Financiero";
            jefeFinPosition.Salary = 610;

            Position secreFin1Position = new Position();
            secreFin1Position.Name = "Secretaria Financiera 1";
            secreFin1Position.Salary = 350;

            Position secreFin2Position = new Position();
            secreFin2Position.Name = "Secretaria Financiera 2";
            secreFin2Position.Salary = 310;

            Position vicAcaPosition = new Position();
            vicAcaPosition.Name = "Vicerector Academico";
            vicAcaPosition.Salary = 780;

            
            Position jefRegistroPosition = new Position();
            jefRegistroPosition.Name = "Jefe de Registro";
            jefRegistroPosition.Salary = 640;

            Position SecreRegistro1Position = new Position();
            SecreRegistro1Position.Name = "Secretaria de Registro 1";
            SecreRegistro1Position.Salary = 400;

            Position SecreRegistro2Position = new Position();
            SecreRegistro2Position.Name = "Secretaria de Registro 2";
            SecreRegistro2Position.Salary = 360;

            Position asistente1Position = new Position();
            asistente1Position.Name = "Asistente 1";
            asistente1Position.Salary = 250;

            Position asistente2Position = new Position();
            asistente2Position.Name = "Asistente 2";
            asistente2Position.Salary = 170;

            Position mensajeroPosition = new Position();
            mensajeroPosition.Name = "Mensajero";
            mensajeroPosition.Salary = 90;

            


            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreFin2Position, contadorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);

            universityTree.CreatePosition(universityTree.Root, vicAcaPosition, rectorPosition.Name);


            universityTree.CreatePosition(universityTree.Root, jefRegistroPosition, vicAcaPosition.Name);
            universityTree.CreatePosition(universityTree.Root, SecreRegistro2Position, jefRegistroPosition.Name);
            universityTree.CreatePosition(universityTree.Root, SecreRegistro1Position, jefRegistroPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asistente2Position, SecreRegistro1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asistente2Position.Name);
            universityTree.CreatePosition(universityTree.Root, asistente1Position, SecreRegistro1Position.Name);


            universityTree.PrintTree(universityTree.Root);

            float totalSalary = universityTree.addSalaries(universityTree.Root);
            Console.WriteLine($"Total Salaries: {totalSalary}");

            Console.ReadLine();
        }
    }
}
