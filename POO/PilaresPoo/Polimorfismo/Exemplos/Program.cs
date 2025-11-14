using Exemplos;

Console.Clear();

PagamentoPix CompraPix = new PagamentoPix();
CompraPix.ValorCompra = 15000;

Console.WriteLine($"Produto: Smartphone");
Console.WriteLine($"Preço: R${CompraPix.ValorCompra}");
Console.WriteLine($"Forma de pagamento: Pix");
Console.WriteLine($"Pagamento com desconto: R${CompraPix.CalcularTotal()}");


PagamentoCartao CompraCartao = new PagamentoCartao();
CompraCartao.ValorCompra = 50;
Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"Preço: R${CompraCartao.ValorCompra}");
Console.WriteLine($"Forma de pagamento: Cartão");
Console.WriteLine($"Pagamento com acrescimo: R${CompraCartao.CalcularTotal()}");

