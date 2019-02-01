using System;

public class ContaCorrente : Conta
{

    public const decimal Taxa = 0.10M;

	public ContaCorrente(string t):base(t)
    {
	}

    public override void Depositar(decimal valor)
    {
        decimal desconto = valor * Taxa;
        base.Depositar(valor - descoto);
    }

    public override void Sacar(decimal valor)
    {
        decimal desconto = valor * Taxa;
        base.Sacar(valor + desconto);
    }

    public override string Id
    {
        get { return Titular + "(CC)"; }
    }
}
