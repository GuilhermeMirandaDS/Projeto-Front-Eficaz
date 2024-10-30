<script setup>
import { RouterLink, RouterView, useRoute } from 'vue-router';
import FooterComponent from './components/FooterComponent.vue';
import PromoCardComponent from './components/PromoCardComponent.vue';
import DestaqueComponent from './components/DestaqueComponent.vue';
import ChildrenComponent from './components/ChildrenComponent.vue';
import HeroComponent from './components/HeroComponent.vue';
import NewProductsComponent from './components/NewProductsComponent.vue';
import CommentsComponent from './components/CommentsComponent.vue';
import NavbarComponent from './components/NavbarComponent.vue';


const route = useRoute();
</script>

<template>
  <div>
    <NavbarComponent/>
  </div>
  <div>
    <div v-if="route.path !== '/register' && route.path !== '/login'  && route.path !== '/user'">
      

      <div class="hero">
        <HeroComponent />
      </div>
      <div class="destaque">
        <DestaqueComponent />
      </div>
      <div class="new">
        <NewProductsComponent />
      </div>
      <div class="promo">
        <PromoCardComponent />
      </div>
      <div class="children">
        <ChildrenComponent />
      </div>
      <div class="Comments">
        <CommentsComponent />
      </div>
      <div class="footer">
        <FooterComponent />
      </div>
    </div>

    <RouterView />
  </div>
</template>