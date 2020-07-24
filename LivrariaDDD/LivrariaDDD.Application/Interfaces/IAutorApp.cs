﻿using LivrariaDDD.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Application.Interfaces
{
    public interface IAutorApp
    {   
        void Create(AutorViewModel autor);
        AutorViewModel Read(int id);
        IEnumerable<LivroViewModel> ReadAll();
        void Update(AutorViewModel autor);
        void Delete(AutorViewModel autor);
    }
}