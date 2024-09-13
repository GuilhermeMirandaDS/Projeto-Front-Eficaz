<template>
    <div class="secao-hero">
      <div class="container-secao-hero">
        <div class="alinhamento-horizontal" style="gap: 80px;">
          <div class="container-esquerda">
            <h1>GABINI HEADSET STORE</h1>
  
            <div class="cta-secao-hero">
              <p class="subtitulo-principal">
                Bem-vindo à qualidade Gabini, com o preço mais acolhedor.
              </p>
              <button class="botao-cta">
                <p class="texto-botao">VEJA MAIS DETALHES</p>
                <img src="@/assets/arrowRight.png" alt="Seta apontando para a direita" />
              </button>
            </div>
  
            <div class="alinhamento-horizontal" style="gap: 3rem;">
              <div class="avaliacao">
                <div class="alinhamento-horizontal" style="gap: 0.75rem;">
                  <p class="subtitulo-avaliacao">4.8</p>
                  <img src="@/assets/star.png" alt="Ícone de estrela" id="icone-estrela" />
                </div>
                <p class="texto-avaliacao">2,290 avaliações</p>
              </div>
  
              <div class="container-compras-mensais">
                <p class="subtitulo-compras-mensais">10K+</p>
                <p class="texto-compras-mensais">Comprado no último mês</p>
              </div>
            </div>
          </div>
  
          <div class="container-direita">

  
            <div class="cartao-produto-hero">
              <img
                src="@/assets/headsetHero.png"
                alt="Cartão com um headset e informações: 2 anos de garantia e 78 horas de bateria."
              />
              <div class="bolha-info" id="info-bateria">
                <img src="@/assets/battery.png" alt="Bateria com duração de 78 horas!" />
                <section class="detalhes-bateria">
                  <p>Bateria</p>
                  <h2>78 horas</h2>
                </section>
              </div>
  
              <div class="bolha-info" id="info-garantia">
                <img src="@/assets/medal.png" alt="2 anos de garantia!" />
                <section class="detalhes-garantia">
                  <p>Garantia</p>
                  <h2>2 anos</h2>
                </section>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  export default {
    name: "HeroSection",
  };
  </script>
  
  <style scoped>
  /* Estilos do texto */
  h1 {
    color: var(--Black-black-500, #000);
    font-family: Inter, sans-serif;
    font-size: 6.25rem;
    font-weight: 700;
    line-height: 5.625rem;
    letter-spacing: -0.25rem;
    text-transform: uppercase;
    width: 34rem;
    margin: 0;
  }
  
  .subtitulo-principal {
    color: var(--Base-100, #1F2026);
    font-family: Inter, sans-serif;
    font-size: 2.25rem;
    font-weight: 600;
    line-height: 2.75rem;
    letter-spacing: -0.09rem;
    width: 29.0625rem;
  }
  
  .subtitulo-compras-mensais {
    color: var(--Black-black-500, #000);
    font-family: Inter, sans-serif;
    font-size: 1.875rem;
    font-weight: 600;
    line-height: 2.375rem;
    letter-spacing: -0.01875rem;
    margin: 0;
  }
  
  .texto-compras-mensais {
    color: var(--Black-black-500, #000);
    font-family: Inter, sans-serif;
    font-size: 0.875rem;
    font-weight: 400;
    line-height: 150%;
  }
  
  .subtitulo-avaliacao {
    color: var(--Black-black-500, #000);
    font-family: Inter, sans-serif;
    font-size: 1.5rem;
    font-weight: 600;
    line-height: 1.875rem;
    letter-spacing: -0.03rem;
    margin: 0;
  }
  
  .texto-avaliacao {
    color: var(--Black-black-200, #8A8A8A);
    font-family: Inter, sans-serif;
    font-size: 1rem;
    font-weight: 400;
    line-height: 1.5rem;
    letter-spacing: -0.01rem;
  }
  
  .bolha-info p {
    color: var(--Black-black-200, #8A8A8A);
    text-align: center;
    font-family: Inter, sans-serif;
    font-size: 1.125rem;
    font-weight: 400;
    line-height: 1.75rem;
    margin: 0;
  }
  
  .bolha-info h2 {
    color: var(--Black-black-500, #000);
    text-align: center;
    font-family: Inter, sans-serif;
    font-size: 1.25rem;
    font-weight: 600;
    line-height: 1.625rem;
    margin: 0;
  }
  
  /* Estilos da seção hero */
  .secao-hero {
    width: 100vw;
    height: 51.4375rem;
    flex-shrink: 0;
  }
  
  .cta-secao-hero {
    border-left: 1px solid #bfc0c2;
    width: fit-content;
    padding: 25px;
  }
  
  .botao-cta {
    display: inline-flex;
    padding: 0.5rem 0.5rem 0.5rem 1.5rem;
    justify-content: center;
    align-items: center;
    gap: 1.875rem;
    border-radius: 2.5rem;
    border: 1px solid var(--White-white-700, #b5b5b5);
    background: var(--White-white-50, #fff);
    color: var(--Black-black-500, #000);
  }
  
  .texto-botao {
    font-family: Inter, sans-serif;
    font-size: 0.875rem;
    font-weight: 600;
    line-height: 1.5rem;
    letter-spacing: -0.00875rem;
    text-transform: uppercase;
  }
  
  .botao-cta:hover {
    border: 1.5px solid #000;
  }
  
  /* Estilos gerais de alinhamento */
  .alinhamento-horizontal {
    display: flex;
    flex-direction: row;
    width: fit-content;
  }
  
  .container-compras-mensais,
  .alinhamento-vertical {
    display: flex;
    justify-content: center;
    flex-direction: column;
  }
  
  #icone-estrela {
    height: 28px;
  }
  
  .avaliacao {
    width: fit-content;
  }
  
  .container-esquerda {
    width: 34rem;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    height: 700px;
  }
  
  .cartao-produto-hero {
    position: relative;
    width: 33.3125rem;
    height: 36.1875rem;
    flex-shrink: 0;
    border-radius: 1.875rem;
    z-index: 2; /* Garante que o headsetHero fique acima da range */
  }
  
  .container-secao-hero {
    display: flex;
    justify-content: center;
    padding: 60px;
  }
  

  
  /* Estilos das informações em bolhas */
  .bolha-info {
    position: absolute;
    display: flex;
    width: 16.25rem;
    padding: 1rem 1.25rem;
    align-items: center;
    gap: 1rem;
    border-radius: 3.75rem;
    background: var(--White-white-50, #fff);
    box-shadow: 0px 24px 44px 0px rgba(226, 216, 239, 0.3);
  }
  
  #info-bateria {
    bottom: 20px;
    left: 20px;
  }
  
  #info-garantia {
    top: 20px;
    right: 20px;
  }
  
  .detalhes-bateria,
  .detalhes-garantia {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: flex-start;
    gap: 0.25
    }
</style>  