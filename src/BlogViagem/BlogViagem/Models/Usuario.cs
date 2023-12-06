﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogViagem.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id {  get; set; }

        
        [Required(ErrorMessage ="Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        public Perfil Perfil { get; set; }

    }

    public enum Perfil
    {
        User,
        Admin
        
    }
}
