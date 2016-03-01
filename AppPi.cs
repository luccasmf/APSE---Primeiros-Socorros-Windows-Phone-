using System.Collections.Generic;

namespace PhoneAppPI
{
    static class AppPi
    {
        static List<Ocorrencia> ocorrencias = new List<Ocorrencia>();

        public static void AdicionarOcorrencia()
        {

            //Acidentes de Trânsito

            Ocorrencia o = new Ocorrencia("Acidentes de Trânsito");

            o.AddPasso("Mantenha a calma e verifique todo o local.");
            o.AddPasso("Garanta a sua segurança, sinalizando a rodovia, evitando possíveis acidentes.");
            o.AddPasso("Tenha controle da situação, afaste as pessoas.");
            o.AddPasso("Verifique a situação da vítima e do acidente.");
            o.AddPasso("Se o carro estiver ligado, se possível desligue a chave e puxe o freio de mão.");
            o.AddPasso("Segure a cabeça do acidentado e não deixe nunca a vítima mover a cabeça, solte apenas quando os socorristas chegarem e solicitarem.");
            o.AddPasso("Verifique se não existem objetos obstruindo as vias aéreas da vítima.");
            o.AddPasso("Em hipótese alguma movimente a vítima, somente pessoas treinadas estão aptas a isso.");
            o.AddPasso("Caso a vítima possua fraturas, não mexer para não agravar o quadro.");
            o.AddPasso("Veja se o cinto de segurança não está engasgando ou dificultando a pessoa acidentada, se for o caso, solte o cinto devagar.");
            o.AddPasso("Tente fazer a pessoa se comunicar, evitando que ela se mova.");
            o.AddPasso("Passe o maior número de informações possíveis, sobre o acidente, aos socorristas.");
            o.AddPasso("Não dê nada para a pessoa beber, não faça torniquetes e não retire o capacete.");
            
            //Hemorragia

            Ocorrencia he = new Ocorrencia("Hemorragia");


            he.AddPasso("É necessário manter e transmitir a calma diante da situação, passando à vítima confiança.");
            he.AddPasso("Se possível, utilize luvas descartáveis.");
            he.AddPasso("Mantenha a pessoa deitada, pois facilita a circulação sanguínea entre o coração e o cérebro, e mantenha a área afetada acima do corpo.");
            he.AddPasso("Caso tenha algum objeto transpassando a vítima, não retire-o.");
            he.AddPasso("Aplique sobre o corte, perfuração ou ferimento, uma compressa com gaze, ou um pano limpo e seco, fazendo uma pressão firme sobre o local com uma ou com as duas mãos, ou mesmo com um dedo, ou ainda uma faixa, dependendo do tamanho e do local do ferimento.");
            he.AddPasso("Se o pano ou gaze ficar encharcado com sangue, este não deve ser trocado, mas mantido no lugar e colocado outro por cima, para não interromper o processo de coagulação do sangue que está sendo contido.");
            he.AddPasso("Continuar a compressão até que a hemorragia estanque (no mínimo 10 min.).");
            he.AddPasso("Em seguida, faça uma ligadura compressiva (que é um curativo bem preso e com certa pressão sobre a região afetada) no local da hemorragia.");
            he.AddPasso("Durante todo esse processo, deve-se manter a vítima calma e acordada, não dar nada para comer ou para beber e mantê-la aquecida.");
            he.AddPasso("No caso de hemorragias nos membros com abundância de sangue, das quais não se pôde conter após ter aplicado as técnicas acima mencionadas, deve-se transportar a vítima, com o membro afetado elevado, imediatamente a uma unidade de saúde mais próxima.");

            //Epilepsia

            Ocorrencia ep = new Ocorrencia("Epilepsia");

            ep.AddPasso("Proteja a cabeça da vítima.");
            ep.AddPasso("Afaste objetos que possam lesionar o indivíduo.");
            ep.AddPasso("Afrouxe as roupas da vítima, como abrir o cinto ou afrouxar a gravata, por exemplo, retirar óculos e relógio e posicioná-lo deitado de barriga para cima com a cabeça virada para o lado para evitar que o mesmo se engasgue.");
            ep.AddPasso("Não dê nada para a vítima beber, não jogue água nem tente segurar o indivíduo. Não tentar forçar a pessoa a ficar quieta.");
            ep.AddPasso("Durante a crise não introduza qualquer objeto na boca nem tente puxar a língua.");
            ep.AddPasso("Permaneça com a pessoa até que recupere os sentidos e respire normalmente.");

            //Parada Cardíaca

            Ocorrencia pc = new Ocorrencia("Parada Cardíaca");

            pc.AddPasso("Antes de tudo, chame a emergência.");
            pc.AddPasso("Deite a vítima no chão, com a barriga para cima. Afaste curiosos que possam atrapalhar o procedimento.");
            pc.AddPasso("Verifique se as vias aéreas não estão obstruídas.");
            pc.AddPasso("Levante um pouco o queixo da vítima para facilitar a respiração.");
            pc.AddPasso("Desaperte as roupas da vítima, como gravatas e cintos.");
            pc.AddPasso("Verifique a pulsação da vítima, caso não haja, proceda com a massagem cardíaca.");
            pc.AddPasso("Na linha imaginária entre os mamilos, apoie uma mão em cima da outra.");
            pc.AddPasso("Faça compressões utilizando seu peso para comprimir o equivalente a um terço da altura do tórax da vítima.");
            pc.AddPasso("Faça as compressões rítmicas e contínuas até a chegada da emergência.");
            pc.AddPasso("Caso possua outra pessoa auxiliando, revezem na massagem cardíaca quando começar a sentir-se cansado.");

            //Queimaduras

            // 1º grau 
            // (Queimadura que fica vermelhidão e ardência na área afetada)

            Ocorrencia q1 = new Ocorrencia("Queimadura1");

            q1.AddPasso("Resfriar bem o local com água corrente ou soro fisiológico em abundância, até que a dor amenize.");
            q1.AddPasso("Não aplique nada sobre o local afetado.");
            q1.AddPasso("Não retirar roupa ou tecidos que ficarem “colados” à pele.");
            q1.AddPasso("Não passar gelo sobre a queimadura, pois o gelo também queima.");
            q1.AddPasso("Não aplicar soluções caseiras como: pó de café, manteiga, creme dental, entre outros.");

            //2º grau 
            //(Aparecem bolhas no local afetado)

            Ocorrencia q2 = new Ocorrencia("Queimadura2");

            q2.AddPasso("Resfriar bem o local com água corrente ou soro fisiológico em abundância.");
            q2.AddPasso("Sem esfregar, deve-se lavar a área com cuidado, utilizando somente agua, não usar álcool.");
            q2.AddPasso("Não “estourar” bolhas que se formarem no local e nem retirar pele que já esteja danificada, colocar uma gaze úmida no local após esfriar e a dor diminuir.");
            q2.AddPasso("O curativo deve permanecer 48 horas sob a região da queimadura e somente após esse tempo pode ser exposta ao livre para evitar infecções.");
            q2.AddPasso("Não retirar roupa ou tecidos que ficarem “colados” à pele.");
            q2.AddPasso("Não aplicar soluções caseiras como: pó de café, manteiga, creme dental, entre outros.");


            //3º grau 
            //(Atingem uma área profunda da pele)

            Ocorrencia q3 = new Ocorrencia("Queimadura3");

            q3.AddPasso("Resfriar bem o local com água fria ou soro fisiológico em abundância.");
            q3.AddPasso("Sem esfregar, deve-se lavar a área com cuidado, utilizando somente água corrente, não usar álcool.");
            q3.AddPasso("Envolver a área afetada em um lençol limpo e molhado com soro fisiológico ou com água.");
            q3.AddPasso("Por se tratar de uma queimadura grave, a vítima deve receber atendimento médico de forma mais rápida possível.");
            q3.AddPasso("Não retirar roupa ou tecidos que ficarem “colados” à pele.");
            q3.AddPasso("Não estourar as bolhas ou retirar a pele das que já estouraram.");
            q3.AddPasso("Não passar gelo sobre a queimadura, pois o gelo também queima.");
            q3.AddPasso("Não aplicar soluções caseiras como: pó de café, manteiga, creme dental, entre outros.");
            q3.AddPasso("Mantenha a vítima aquecida, pois ocorre hipotermia (perda de calor), preservar a área afetada.");



            //Engasgos
            //Bebês e Crianças

            Ocorrencia e1 = new Ocorrencia("Engasgo Infantil");

            e1.AddPasso("Mantenha a calma e chame a emergência.");
            e1.AddPasso("Quando possível, coloque a criança de barriga para baixo em seu braço, de modo que a cabeça fique mais baixa.");
            e1.AddPasso("Segure o queixo com a mão do braço em que a criança está apoiada.");
            e1.AddPasso("Com a outra mão faça cinco compressões no meio das costas.");
            e1.AddPasso("Reavalie o estado da criança, Caso continue o engasgo, repita a manobra.");
            e1.AddPasso("Caso nada funcione e houver ausência de batimentos cardíacos, inicie a manobra de parada cárdio respiratória.");
            e1.AddPasso("Com dois dedos faça cinco compressões no tórax, abaixo da linha imaginária que liga um mamilo ao outro.");
            e1.AddPasso("Mesmo que o processo tenha sido bem sucedido, leve a criança a uma unidade de saúde para avaliação.");


            //Engasgos
            //Adulto

            Ocorrencia e2 = new Ocorrencia("Engasgo");

            e2.AddPasso("Fique de pé atrás da vítima.");
            e2.AddPasso("Passe o braço em torno do tronco da vítima.");
            e2.AddPasso("Posicione sua perna de apoio entre as pernas da vítima para segurá-la em caso de queda.");
            e2.AddPasso("Cerre o punho da mão direita e coloque-a sobre a boca do estômago da vítima.");
            e2.AddPasso("Coloque a outra mão sobre o punho cerrado.");
            e2.AddPasso("Faça pressão com as mãos contra o estômago da vítima para dentro e para cima.");
            e2.AddPasso("Caso a vítima continue engasgada, repita a manobra.");


            //Afogamento

            Ocorrencia af = new Ocorrencia("Afogamento");

            af.AddPasso("Deite a vítima de lado, para que os fluídos não engasguem a pessoa.");
            af.AddPasso("Se a vítima estiver em apneia (falta de respiração), e você se sentir à vontade para tal, utilize a respiração boca a boca, assoprando vigorosamente o ar dentro da cavidade bucal dela em intervalos regulares, preserve sua segurança durante a respiração boca a boca, utilizando uma barreira. Exemplo: plástico furado.");
            af.AddPasso("Realize sopros ritmados com intervalos de aproximadamente cinco segundos.");
            af.AddPasso("Prossiga com a manobra até que a vítima possa respirar sozinha.");
            af.AddPasso("Verifique a pulsação e se a vítima estiver sem pulso realize massagem cardíaca.");
            af.AddPasso("Na linha imaginária entre os mamilos, apoie uma mão em cima da outra.");
            af.AddPasso("Faça compressões utilizando seu peso para comprimir o equivalente a um terço da altura do tórax da vítima.");
            af.AddPasso("Faça as compressões rítmicas e contínuas até a chegada da emergência.");
            af.AddPasso("Caso possua outra pessoa auxiliando, revezem na massagem cardíaca quando começar a sentir-se cansado.");


            //Quedas

            Ocorrencia qu = new Ocorrencia("Quedas");

            qu.AddPasso("Mantenha calma e garanta que o ambiente não fornece riscos para uma nova queda.");
            qu.AddPasso("Se a queda for grave, acima de dois metros ou contato forte com o chão, solicite logo o auxílio médico.");
            qu.AddPasso("Realize o controle cervical, não permitindo que a vitima movimente a cabeça.");
            qu.AddPasso("Observe se a vítima está consciente e responde quando é chamada, se estiver consciente a oriente para não fazer nenhum movimento.");
            qu.AddPasso("Em caso de sangramento fazer pressão sobre o local da hemorragia com um pano limpo por, pelo menos dez minutos ou até chegada da ajuda médica, salvo sangramento em cabeça, ouvido e nariz.");
            qu.AddPasso("Em caso de fratura (Para fratura exposta não realize nenhuma ação) imobilizar o membro lesionado na posição em que está com tábuas, ataduras ou lençóis.");
            qu.AddPasso("Verifique a pulsação e se a vítima estiver sem pulso realize massagem cardíaca.");
            qu.AddPasso("Na linha imaginária entre os mamilos, apoie uma mão em cima da outra.");
            qu.AddPasso("Faça compressões utilizando seu peso para comprimir o equivalente a um terço da altura do tórax da vítima.");
            qu.AddPasso("Faça as compressões rítmicas e contínuas até a chegada da emergência.");
            qu.AddPasso("Caso possua outra pessoa auxiliando, revezem na massagem cardíaca quando começar a sentir-se cansado.");



            ocorrencias.Add(he);
            ocorrencias.Add(ep);
            ocorrencias.Add(pc);
            ocorrencias.Add(q1);
            ocorrencias.Add(q2);
            ocorrencias.Add(q3);
            ocorrencias.Add(e1);
            ocorrencias.Add(e2);
            ocorrencias.Add(af);
            ocorrencias.Add(qu);
            ocorrencias.Add(o);
        }

        public static Ocorrencia carregarOcorrencia(string nome)
        {
            Ocorrencia o = ocorrencias.Find(p => p.ocorrencia == nome);
            return (o);
        }

        public static void LerArquivo()
        {

        }

        public static void Serializar()
        {

        }
    }
}
