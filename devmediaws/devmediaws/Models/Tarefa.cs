﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace devmediaws.Models
{
    [Table("Tarefas")]
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public String Titulo { get; set; }

        [MaxLength(200)]
        public String Descricao { get; set; }
    }
}