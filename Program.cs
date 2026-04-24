const double TaxaIOFmes = 0.0038;
const double TaxaIOFdia = 0.000082;
decimal ValorTotalFatura;
double  PercentualPagamentoMinimo, TaxaJurosMensais;

decimal ValorPagamentoMinimo, ValorNaoPago, ValorJuros, ValorIOFmes, ValorIOFDiario, ValorProximaFatura, CustoCreditoRotativo;


Console.WriteLine("--- Crédito Rotativo de Cartão de Crédito ---\n ");

Console.Write("Valor total da fatura (R$)....:");
ValorTotalFatura = Convert.ToDecimal (Console.ReadLine());
Console.Write("Pagamento mínimo (%)....:");
PercentualPagamentoMinimo = Convert.ToDouble(Console.ReadLine()) / 100;
Console.Write("Taxa de juros mensais (%)....:");
TaxaJurosMensais = Convert.ToDouble(Console.ReadLine()) / 100;

ValorPagamentoMinimo = ValorTotalFatura * Convert.ToDecimal(PercentualPagamentoMinimo);
ValorNaoPago = ValorTotalFatura - ValorPagamentoMinimo;
ValorJuros = ValorNaoPago * Convert.ToDecimal(TaxaJurosMensais);
ValorIOFmes = ValorNaoPago * Convert.ToDecimal(TaxaIOFmes);
ValorIOFDiario = ValorNaoPago * Convert.ToDecimal(TaxaIOFdia * 30);

ValorProximaFatura = ValorNaoPago + ValorJuros + ValorIOFmes + ValorIOFDiario;
CustoCreditoRotativo = ValorProximaFatura - ValorNaoPago;

Console.WriteLine("\n Pagamento mínimo..:");

Console.WriteLine($"Caso seja pago o valor mínimo: {ValorPagamentoMinimo:C2}");
Console.WriteLine($"");
Console.WriteLine($"Valor não pago....................: {ValorNaoPago:C}");
Console.WriteLine($"Juros.............................: {ValorJuros:C}");
Console.WriteLine($"IOF mensal........................: {ValorIOFmes:C}");
Console.WriteLine($"IOF diário........................: {ValorIOFDiario:C}");
Console.WriteLine($"");
Console.WriteLine($"Valor a pagar na próxima fatura...: {ValorProximaFatura:C}");
Console.WriteLine($"Custo do crédito rotativo.........: {CustoCreditoRotativo:C}");