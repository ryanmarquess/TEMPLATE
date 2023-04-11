namespace Template.Models;
public class histórico
{
/* No trecho de código a seguir são criados os 
atributos de Cliente e seus getters e setters
correspondentes. */
public int Data { get; set; }
public string Versão { get; set; }
public string Descrição { get; set; }
public string Autor { get; set; }
/* Nesse trecho do código, é criado o Construtor do 
model Cliente e determinado quais parâmetros são 
necessários na criação das instâncias. */
public histórico(int data, string versão, string descrição, string autor)
{
this.Data = data;
this.Versão = versão;
this.Descrição = descrição;
this.Autor = autor;
}
}
