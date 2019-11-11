# TabelaFut
**Trabalho Prático de Engenharia de Software II – Sistema de Gestão de Campeonato de Futebol**

Este trabalho foi executado durante a disciplina de Engenharia de Software II, com o objetivo de implementar um Sistema de Gestão de Campeonato de Futebol.

# Descrição Geral do Produto  
**Lista de requisitos funcionais**  
**R01** – O sistema deve manter informações cadastrais de todos os atletas que disputam o torneio.  
**R02** – O sistema deve fazer a gestão da tabela do campeonato, detalhando informações de jogos  
ganhos, perdidos e empates. Além disso deve ser controlado a quantidade de gols feitos, sofridos e
saldo de gols.  
**R03** – O sistema deve manter para quais campeonatos são cedidas vagas automáticas, dada a
classificação no campeonato.  
**R04** – O sistema deve manter informações cadastrais de todas as equipes que disputam o torneio.  
**R05** – O sistema deve fazer a gestão de cada rodada do campeonato.  
**R06** – O sistema deve construir a tabela do campeonato.  
**R07** – O sistema deve permitir que os torcedores visualizem os resultados dos jogos por rodada, ou por
equipe.  
**R08** – O sistema deve manter informações cadastrais de todos os locais habilitados para realizar
partidas do campeonato.  
**R09** – O sistema deve manter informações cadastrais de todos os árbitros que podem apitar jogos do
campeonato.  
**R10** – O torcedor pode visualizar o placar, local do jogo e árbitros dos jogos.

# Regras de negócio inicialmente identificadas
**RN00** – Quantidade de Atletas por time  
**Descrição:** Cada time deve ter 24 atletas inscritos.  
**RN01** – Pontuação dos jogos  
**Descrição:** Time vencedor ganha 3 pontos, Time perdedor não soma pontos, e em caso de empate
cada time ganha 1 ponto.  

**RN02** – Quantidade de times e rodadas no campeonato  
**Descrição:** o Campeonato deve ter 20 equipes e 19 rodadas.  
**RN03** – Definição das rodadas.  
**Descrição:** Antes do inicio do campeonato as rodadas devem ser definidas.  
• Cada rodada deve ter 10 jogos, sendo os confrontos definidos de forma aleatória. Todas as
equipes se enfrentam apenas 1 vez durante o campeonato.  
• O sistema deve construir as 19 rodadas de forma sequencial, ou seja, a segunda rodada só
pode ser sorteada após o fim do sorteio da rodada 1 e assim sucessivamente até construir as 19
rodas. Não podem ocorrer confrontos repetidos dentro do campeonato.  
• O local da partida também deve ser sorteado, e pode ser realizado somente na cidade de um
dos 2 times envolvidos na partida.  
**RN04** – Quantidade árbitros por partida  
**Descrição:** Cada partida deve ter escalado 4 árbitros.  
