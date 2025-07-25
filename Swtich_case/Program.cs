Console.WriteLine("\nBem vindo(a) ao atendimento de suporte!");

Console.WriteLine("\nPara prosseguirmos, me conte melhor sobre o que precisa: ");

Console.WriteLine("\n1 - Financeiro \n2 - Suporte Técnico \n3 - Comercial \n4 - Cancelamento \n5 - Falar com atendente");
int op = int.Parse(Console.ReadLine());

switch (op)
{
    case 1:
        Console.WriteLine("\nVocê escolheu a opção Financeiro...");
        Console.WriteLine("\nEscolha uma opção a qual deseja ser atendido: ");

        Console.WriteLine("\n1 - Pagamento de fatura \n2 - Solicitar segunda via");
        int opFinanceiro = int.Parse(Console.ReadLine());

        if (opFinanceiro == 1)
        {
            Console.WriteLine("\nOpções disponiveis para pagamento: ");

            Console.WriteLine("\n1 - Cartão débito \n2 - Cartão crédito \n3 - PIX ");
            int opPag = int.Parse(Console.ReadLine());

            if (opPag == 1 || opPag == 2 || opPag == 3)
            {
                Console.WriteLine("\nSerá gerado um link para o pagamento de sua fatura no valor de: R$ 149,99  ");
                Console.WriteLine("\nLink para pagamento: ");
                Console.WriteLine("\nhttps://www.youtube.com/watch?v=dQw4w9WgXcQ&list=RDdQw4w9WgXcQ&start_radio=1 ");
            }
            else
            {
                Console.WriteLine("\nPagamento falhou");
            }
        }
        else if (opFinanceiro == 2)
        {
            Console.WriteLine("\nLink para segunda-via: ");
            Console.WriteLine("\nhttps://www.youtube.com/watch?v=dQw4w9WgXcQ&list=RDdQw4w9WgXcQ&start_radio=1 ");
        }
        else
        {
            Console.WriteLine("\nInsira uma opção válida");
        }
        break;

    case 2:
        Console.WriteLine("\nVocê escolheu a opção Suporte Técnico...");
        Console.WriteLine("\nEscolha uma opção a qual deseja ser atendido: ");

        Console.WriteLine("\n1 - Solicitar visita \n2 - Chat online");
        int opST = int.Parse(Console.ReadLine());

        if (opST == 1)
        {
            Console.WriteLine("\nInsira seu endereço abaixo: ");
            string endereço = Console.ReadLine();

            Console.WriteLine($"\nIremos te visitar em {endereço} dentro de 48h ");
        }
        else if (opST == 2)
        {
            Console.WriteLine("\nAguarde, um atendente especializado já irá te atender...");
        }
        else
        {
            Console.WriteLine("\nInsira uma opção válida");
        }
        break;

    case 3:
        Console.WriteLine("\nVocê escolheu a opção Comercial...");
        Console.WriteLine("\nEscolha uma opção a qual deseja ser atendido: ");

        Console.WriteLine("\n1 - Planos \n2 - Promoções");
        int opComercial = int.Parse(Console.ReadLine());

        if (opComercial == 1)
        {
            Console.WriteLine("\nAtualmente seu plano é: Silver");
        }
        else if (opComercial == 2)
        {
            Console.WriteLine("\nAtualmente temos uma promoção para o plano Gold");
            Console.WriteLine("\nSua fatura será de: R$ 149,99/Mês \nDeseja prosseguir? \n 1 - Sim \n 2 - Não");
            int opComercialDecisão = int.Parse(Console.ReadLine());

            if (opComercialDecisão == 1)
            {
                Console.WriteLine("\nSeu plano gold foi adquirido com sucesso!");
            }
            else if (opComercialDecisão == 2)
            {
                Console.WriteLine("\nAtualização de plano cancelada!");
            }
            else
            {
                Console.WriteLine("\nInsira uma opção válida");
            }
        }
        break;

    case 4:
        Console.WriteLine("\nVocê escolheu a opção Cancelamento...");
        Console.WriteLine("\nEscolha uma opção a qual deseja ser atendido: ");

        Console.WriteLine("\n1 - Solicitar cancelamento");
        int opCancelamento = int.Parse(Console.ReadLine());

        if (opCancelamento == 1)
        {
            Console.WriteLine("\nSeu cancelamento foi solicitado...");
            Console.WriteLine("\nDentro de 3 dias uteis iremos cortar por total seu plano.");
            Console.WriteLine("\nObrigado(a) por fazer parte do nosso mundo... Esperamos que você volte :(");
        }
        else
        {
            Console.WriteLine("\nInsira uma opção válida");
        }
        break;

    case 5:
        Console.WriteLine("\nVocê escolheu a opção Falar com um atendente...");
        Console.WriteLine("\nEscolha uma opção a qual deseja ser atendido: ");

        Console.WriteLine("\n1 - Chat online \n2 - Falar por telefone ");
        int opAtendimento = int.Parse(Console.ReadLine());

        if (opAtendimento == 1)
        {
            Console.WriteLine("\nAguarde... você receberá um link para nosso chat online");
            Console.WriteLine("\n...");
            Console.WriteLine("\n...");
            Console.WriteLine("\n...");
            Console.WriteLine("\nhttps://www.youtube.com/watch?v=dQw4w9WgXcQ&list=RDdQw4w9WgXcQ&start_radio=1");
        }
        else if (opAtendimento == 2)
        {
            Console.WriteLine("\nPor favor, informe seu número de telefone com (DDD)");
            double opAtendimentoTel = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nPerfeito! Seu número: {opAtendimentoTel} foi registrado e iremos entrar em contato dentro de 24h...");
        }
        else
        {
            Console.WriteLine("\nInsira uma opção válida");
        }
        break;

    default:
        Console.WriteLine("\nInsira uma opção válida");
        break;
}