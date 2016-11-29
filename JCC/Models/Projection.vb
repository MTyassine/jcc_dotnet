Using System;
Using System.Data.Entity;
Using System.ComponentModel.DataAnnotations;
Using System.ComponentModel.DataAnnotations.Schema;
Namespace JCC.Models
    Public Class Projection{
    Public int id {Get;Set;}
    Public Time horaire{Get; Set;}
    Public virtual Cinema Cinema { Get; Set; }
    Public virtual Film Film{ Get; Set; }

            }