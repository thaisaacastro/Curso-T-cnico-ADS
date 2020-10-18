1 -
 
Algoritmo "CreditoEspecial"
var
 SaldoMedio, valorCredito : real
 
 Inicio
 
 Escreva("Informe seu saldo Médio: ")
 leia(SaldoMedio)
 
 SE(SaldoMedio <= 2000) ENTAO
 valorCredito = 0
 FIMSE
 
 SE(SaldoMedio > 2000 || SaldoMedio <= 4000) ENTAO
 valorCredito = SaldoMedio * 0.2
 FIMSE
 
 SE(SaldoMedio > 4000 || SaldoMedio <= 6000) ENTAO
 valorCredito = SaldoMedio * 0.3
 FIMSE
 
 SE(SaldoMedio > 6000)
 valorCredito = SaldoMedio * 0.4
 FIMSE
 
 Escreva("Seu novo saldo médio é: ", SaldoMedio)

 
 FIM

///////////////////////////////////////////////////////////////////// 

2 -
    Algoritmo "Pedido"
    var 
        CodItemPed, Quant : inteiro
        Unit, Valor : real

        Inicio 

        Escreva("Informe o código: ")
        leia(CodItemPed)

        Escreva("Informe a quantidade: ")
        leia(Quant)

        SE(CodItemPed = 100) ENTAO
        Unit <- 7.9
        Valor <- Quant * Unit
        FIMSE

        SE(CodItemPed = 101) ENTAO
        Unit <- 4.9
        Valor <- Quant * Unit
        FIMSE

        SE(CodItemPed = 102) ENTAO
        Unit <- 6.5
        Valor <- Quant * Unit
        FIMSE

        SE(CodItemPed = 103) ENTAO
        Unit <- 9.9
        Valor <- Quant * Unit
        FIMSE

        SE(CodItemPed = 104) ENTAO
        Unit <- 10.9
        Valor <- Quant * Unit
        FIMSE

        SE(CodItemPed = 105) ENTAO
        Unit <- 3.6
        Valor <- Quant * Unit 

        SE(CodItemPed < 105 || CodItemPed > 100 ) ENTAO
        Escreva("Código não encontrado!")

        
        Escreva("Seu pedido ficou em: ", valor)
        
        FIM

        ///////////////////////////////////////////////////////////

    3 - 

    Algoritmo "Triangulo"
        var 
            lado01, lado02, lado03: inteiro
        
        Escreva("Digite primeiro lado: ")
        Leia(lado01)

        Escreve("Digite segundo lado: ")
        Leia(lado02)

        Escreve("Digite terceiro lado: ")
        Leia(lado03)

        SE ((lado01 = lado02) E (lado01 = lado03) E (lado02 = lado03)) ENTAO
        Escreva("Seu triângulo é Equilátero")
        FIMSE;

        SE(
            ((lado01 = lado02) E (lado01 OU lado02 <> lado03)) ||
            ((lado02 = lado03) E (lado02 OU lado03 <> lado01)) ||
            ((lado03 = lado01) E (lado03 OU lado01 <> lado02))
        ) ENTAO 
        Escreve("Seu triangulo é Isósceles")
        FIMSE;

        SE(
            ((lado01 <> lado02) E (lado01 <> lado03) E (lado02 <> lado03)
        ) ENTAO 
        Escreve("Seu triangulo é Escaleno")
        FIMSE;

        ///////////////////////////////////////////////////////////

        /___Desafio___/

        G = gato
        T = tartaruga
        M = mesa
        M + G - T = 170
        M + T - G = 130
        2M - 170 + 130;
        2M = 300;
        M = 300 / 2;
        M = 150;
        M = 150cm / 100;
        M = 1,5M;

        