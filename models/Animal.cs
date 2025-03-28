using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace AdotePet.models
{
    public class Animal
    {
        public string? Id { get; set; }
        public string? Nome { get; set; }
        public string? Personalidade { get; set; }
        public Char tipo { get; set; }

    }
}