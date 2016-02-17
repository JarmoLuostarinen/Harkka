﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees2._0.Model
{
   public class EmployeeImage
    {
        public string Path { get; set; }
    }
    /// <summary>
    /// This class holds all Employee Image objecs in a collections.
    /// </summary>
    // yllä olevien kuvatiedostojen tietomalli, joka voidaan Bindata UI-komponenttiin
    public class EmployeeImageViewModel
    {
        private List<EmployeeImage> images;
        public List<EmployeeImage> Images { get { return images; } }

        public EmployeeImageViewModel()
        {
            images = new List<EmployeeImage>();
            images.Add(new EmployeeImage { Path = "Assets/Images/employee01.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee02.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee03.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee04.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee05.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee06.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee07.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee08.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee09.png" });
            images.Add(new EmployeeImage { Path = "Assets/Images/employee10.png" });
        }
    }
}
