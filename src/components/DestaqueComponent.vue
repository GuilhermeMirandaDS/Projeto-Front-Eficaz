<template>
  <div class="container">
    <div class="image-container">
      <img src="../assets/fonePreto1.png" alt="Headset A50" class="default-image">
      <img src="../assets/fonePreto2.png" alt="Headset HyperX" class="hover-image">
    </div>
    <div class="image-container">
      <img src="../assets/foneBranco1.png" alt="Headset HyperX" class="default-image">
      <img src="../assets/foneBranco2.png" alt="Headset A50" class="hover-image">
    </div>
  </div>
</template>

<script>
export default {
  name: 'ImageDisplay',
}
</script>

<style scoped>
.container {
  display: flex; 
  flex-wrap: wrap;
  justify-content: space-between; 
  max-width: 100%; 
  padding: 10px;
  margin-bottom: 50%;
}

.image-container {
  position:relative;
  width: 45%; 
  margin: 20px; 
}

.image-container img {
  width: 94%;
  height: auto;
  border-radius: 10px;
  transition: opacity 0.3s ease;
}

.default-image {
  position: absolute;
  top: 0;
  left: 0;
}

.hover-image {
  opacity: 0;
  position: absolute;
  top: 0;
  left: 0;
}

.image-container:hover .default-image {
  opacity: 0;
}

.image-container:hover .hover-image {
  opacity: 1;
}

@media (max-width: 768px) {
  .container {
    flex-direction: column;
    align-items: center;
  }

  .image-container {
    width: 80%;
  }
}

@media (max-width: 480px) {
  .image-container {
    width: 100%;
  }
}
</style>
