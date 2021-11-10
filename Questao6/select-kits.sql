select
    prd.nome as nome_produto_limpeza,
    ali.nome as nome_alimento,
    (eet.preco + aeet.preco) * 0.85 as preco_kit,
    ((eet.preco + aeet.preco) * 0.85) - (eet.custo + aeet.custo) as lucro_kit,
    ali.data_validade as validade_kit
from produto_limpeza prd
         full join alimento ali
                   on 1 = 1
         join elemento_estoque eet
              on prd.id_elemento_estoque = eet.id
         join estoque est
              on eet.id = est.id_elemento_estoque
         join pesquisa_mercado psq
              on prd.id = psq.id_produto_limpeza
         join elemento_estoque aeet
              on ali.id_elemento_estoque = aeet.id
         join estoque aest
              on aeet.id = aest.id_elemento_estoque
where
        est.quantidade > 0
  and aest.quantidade > 0
  and psq.satisfacao > 70
  and (ali.data_validade - now()::date) < 5
order by lucro_kit desc
