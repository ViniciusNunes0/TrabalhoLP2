using System;

public abstract class Conta  
{
    private decimal saldo;
    private string titular;

	public Conta(string t)
	{
        titular = t;
	}

    public abstract string Id
    {
        get;
    }

    public virtual void Depositar(decimal valor)
    {
        Saldo += valor;
    }
    public virtual void Sacar(decimal valor)
    {
        if (valor <= saldo)
            saldo -= valor;
           
    }
    public decimal Saldo
    {
        get { return saldo; }
    }

    public string Titular
    {
        get { return titular; }
    }

}
