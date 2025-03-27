﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PruebaEntityFramerok.Models{    
      
        public class HckPersona       
        {
            
            public string Cedula { get; set; }            
            public string Nombres { get; set; }           
            public string Apellidos { get; set; }            
            public string Ciudadania { get; set; }            
            public DateTime? FechaNacimiento { get; set; }           
            public string EstadoCivil { get; set; }           
            public string Profesion { get; set; }       
            public string NivelEstudios { get; set; }            
            public int? EsCliente { get; set; }
            public string TipoPersona { get; set; }
        }
    }

