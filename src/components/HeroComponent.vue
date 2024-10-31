<template>
  <div class="heroSection" v-intersect="onIntersect">
    <div class="imagem__linha">
      <img src="../assets/Range.png" alt="" class="imagem__animada" />
      <img src="../assets/Range2.png" alt="" class="imagem__animada2 imagem__linha2">
    </div>

    <div class="containerSection">
      <div class="container">
        <h1 class="titulo" :class="{ 'animate-complex': visible }">GABINI HEADSET STORE</h1>

        <div class="container__textos" :class="{ 'animate-complex delay-1': visible }">
          <hr />
          <div>
            <h3 class="subTitulo">
              Welcome to Gabini quality, at our most welcoming price.
            </h3>
            <a href="#" class="buttonBase" :class="{ 'animate-complex delay-2': visible }">
              <div class="seeMoreDetails">SEE MORE DETAILS</div>
              <div class="iconsWrapper">
                <img class="icons2" alt="" src="../assets/seta.svg" />
              </div>
            </a>
          </div>
        </div>

        <div class="container__avaliacao" :class="{ 'animate-complex delay-3': visible }">
          <div class="frameContainer">
            <div class="parent">
              <div class="avaliacao__texto">4.8</div>
              <div class="iconParent">
                <img
                  class="icon"
                  alt=""
                  src="../assets/estrela.png"
                  v-for="n in 4"
                  :key="n"
                />
                <img class="icon4" alt="" src="../assets/estel.png" />
              </div>
            </div>
            <div class="ratings">2.290 avaliações</div>
          </div>

          <div class="frameDiv">
            <div class="kWrapper">
              <div class="k">10K+</div>
            </div>
            <div class="boughtInPast">Comprado no mês passado</div>
          </div>
        </div>
      </div>

      <div  :class="{ 'animate-complex delay-4': visible }">
        <div class="imagem__apresentacao"></div>
        <img src="../assets/heasetpretoazul.png" alt="" class="imagem__fone" />

        <div class="container__garantia">
          <div>
            <img src="../assets/medalha.svg" alt="" class="icone__bolinha" />
          </div>
          <div class="inf">
            <h3 class="">Warranty</h3>
            <h4 class="">2 years</h4>
          </div>
        </div>

        <div class="container__bateria">
          <div>
            <img src="../assets/bateria.svg" alt="" class="icone__bolinha" />
          </div>
          <div class="inf">
            <h3 class="">Batery</h3>
            <h4 class="">78 Hours</h4>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { ref } from 'vue';

export default {
  setup() {
    const visible = ref(false);

    const onIntersect = (entries) => {
      entries.forEach((entry) => {
        if (entry.isIntersecting) {
          visible.value = true;
        }
      });
    };

    return {
      visible,
      onIntersect
    };
  },
  directives: {
    intersect: {
      mounted(el, binding) {
        const observer = new IntersectionObserver(binding.value);
        observer.observe(el);
      },
    },
  },
};
</script>
<style scoped>
.heroSection{
  margin-top: 5%;
}

h3, h4{
  font-family: 'Inter', sans-serif;
}

@keyframes complexEntry {
  0% {
    opacity: 0;
    transform: translateY(50px) scale(0.95);
  }
  100% {
    opacity: 1;
    transform: translateY(0) scale(1);
  }
}

.animate-complex {
  opacity: 0;
  animation: complexEntry 1.8s cubic-bezier(0.68, -0.55, 0.27, 1.55) forwards;
}

.delay-1 {
  animation-delay: 0.1s;
}
.delay-2 {
  animation-delay: 0.25s;
}
.delay-3 {
  animation-delay: 0.35s;
}
.delay-4 {
  animation-delay: 0.3s;
}

.imagem__linha img {
  position: absolute;
  width: 84%;
  max-width: 100%;
  margin-left: 15%;
  margin-top: 0px;
  z-index: 0;
  overflow: hidden;
}

.imagem__linha2 {
  width: 45.9% !important;
  margin-left: 53% !important;
  margin-top: 210px !important;
  overflow: hidden;
}

.containerSection {
  display: flex;
  justify-content: space-evenly;
  flex-wrap: wrap;
}

.container {
  margin-left: 0px;
  gap: 46px;
}

.titulo {
  font-size: 90px;
  font-weight: bold;
  width: 100px;
  line-height: 1em;
  margin-top: 50px;
  font-family: 'inter', sans-serif;
  letter-spacing: -3px;
  text-shadow: 0px 3px 3px rgba(0, 0, 0, 0.23);
}

.container__textos {
  display: flex;
  gap: 25px;
}

.subTitulo {
  width: 465px;
  color: #1F2026;
  font-size: 36px;
  font-family: 'inter', sans-serif;
  font-weight: 600;
  margin-top: -10px;
}

.seeMoreDetails {
  font-size: 14px;
  font-weight: 600;
  font-family: 'inter', sans-serif;
}

.buttonBase {
  display: flex;
  align-items: center;
  justify-content: center;
  gap: 30px;
  width: 232px;
  height: 56px;
  border: 1px solid #b5b5b5;
  border-radius: 40px;
  text-decoration: none;
  color: black;
  cursor: pointer;
}
.buttonBase:hover {
  background-color: #f0f0f0;
  border-color: #000000;
  box-shadow: 0px 4px 12px rgba(0, 0, 0, 0.2);
  transform: scale(1.05);
}

.iconsWrapper {
}

.icons2 {
  background-color: black;
  padding: 0.3em;
  border-radius: 50%;
  margin-top: 4px;
}

.container__avaliacao {
  display: flex;
  margin-top: 80px;
  align-items: center;
  gap: 80px;
  margin-bottom: 20px;
}

.parent {
  display: flex;
  align-items: start;
}

.avaliacao__texto {
  font-size: 24px;
  font-weight: 600;
  font-family: 'inter', sans-serif;
  margin-bottom: 10px;
}

.k {
  font-size: 30px;
  font-weight: 600;
  font-family: 'inter', sans-serif;
  margin-bottom: 6px;
}

.boughtInPast {
  font-family: 'inter', sans-serif;
}

.ratings {
  color: #a1a1a1;
  font-family: 'inter', sans-serif;
}

.imagem__apresentacao {
  background-image: url("../assets/Rectangle.png");
  background-repeat: no-repeat;
  background-size: 90%;
  width: 105%;
  height: 100%;
  z-index: 10;
  position: absolute;
  margin-top: 155px;
  margin-left: -30px;
}

.imagem__fone {
  margin-top: 130px;
  margin-left: 20px;
  width: 95%;
  z-index: 11;
  position: relative;
}

.container__garantia {
  position: relative;
  display: flex;
  align-items: center;
  background-color: white;
  padding: 16px 20px;
  gap: 16px;
  height: 52px;
  width: 230px;
  z-index: 13;
  margin-top: -510px;
  margin-left: -15px;
  border-radius: 60px;
  box-shadow: 0px 3px 3px rgba(0, 0, 0, 0.2);
}
.container__bateria:hover {
  background-color: #f0f0f0; 
  border-color: #000000; 
  box-shadow: 0px 4px 12px rgba(0, 0, 0, 0.2); 
  transform: scale(1.05); 
}

.icone__bolinha {
  padding: 0.6em;
  background-color: black;
  border-radius: 50%;
}

.inf h3{
  font-size: 18px;
  color: #a1a1a1;
  font-family: 'inter' sans-serif;
}

.inf h4{
  font-size: 20px;
  font-weight: 600;
  font-family: 'inter' sans-serif;
  margin-top: -10px;
}

</style>

