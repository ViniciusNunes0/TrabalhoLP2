using System;
using System.ComponentModel.DataAnnotations;
public class Cliente
{
    public string nome { get; set; }

    [Key]
    public int idCliente { get; set; }
    
}