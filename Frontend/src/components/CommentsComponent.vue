<template>
    <div class="testimonials-container">
      <h2>TESTIMONIALS</h2>
      <p style="color: #aaa;">Voices of Satisfaction: Discover What Our Clients Have to Say</p>
      
      <transition
        name="slide"
        @before-enter="beforeEnter"
        @enter="enter"
        @leave="leave"
      >
        <div class="card-wrapper" :key="currentIndex">
          <div 
            class="testimonial-card" 
            v-for="(testimonial, index) in paginatedTestimonials" 
            :key="testimonial.name"
          >
            <div class="stars">★★★★★</div>
            <p>{{ testimonial.text }}</p>
            <div class="profile">
              <img :src="testimonial.img" alt="Profile picture" />
              <p>{{ testimonial.name }}</p>
              <small>{{ testimonial.role }}</small>
            </div>
          </div>
        </div>
      </transition>
  
      
      <div class="carousel-controls">
        <button class="control-btn light" @click="prevTestimonials">←</button>
        <button class="control-btn dark" @click="nextTestimonials">→</button>
      </div>
    </div>
  </template>
  
  
  <script>
  import profile1 from '@/assets/Comment_1.png';
  import profile2 from '@/assets/Comment_2.jpeg';
  import profile3 from '@/assets/Comment_3.png';
  import profile4 from '@/assets/Comment_4.jpeg';
  import profile5 from '@/assets/Comment_5.jpeg';
  import profile6 from '@/assets/Comment_6.jpeg';
  
  export default {
    data() {
      return {
        currentIndex: 0,
        testimonialsPerPage: 3,
        testimonials: [
          { name: "Martina Jolie", role: "CEO, Coffee", text: "I absolutely love this coffee maker! I use it every morning. Cold coffee is my favorite and this little machine makes great cold coffee. It is strong and tasty. I regular coffee cup or a larger stainless steel cup will work.", img: profile1 },
          { name: "Jhonaton Albert", role: "CEO, Samsung", text: "I love the slim design of this Keurig. It works well except for the cold coffee. It states it does both hot and cold but I haven't found that to be accurate. The hot is perfect but it doesn't produce the cold coffee.", img: profile2 },
          { name: "Stevano Albert", role: "CEO, Mayvue", text: "Nothing wrong with the maker but seller had it On sale truns out their supposed sale price was actually what the product actually sells for normally. It's retail price is 119.99. And is currently on sale for 64.99", img: profile3 },
          { name: "Ana Smith", role: "Founder, StartupX", text: "I absolutely love this coffee maker! I use it every morning. Cold coffee is my favorite and this little machine makes great cold coffee. It is strong and tasty. I regular coffee cup or a larger stainless steel cup will work.", img: profile4 },
          { name: "Lucas Brown", role: "Manager, BusinessCo", text: "I love the slim design of this Keurig. It works well except for the cold coffee. It states it does both hot and cold but I haven't found that to be accurate. The hot is perfect but it doesn't produce the cold coffee.", img: profile5 },
          { name: "Elena White", role: "CEO, TechCorp", text: "Nothing wrong with the maker but seller had it On sale truns out their supposed sale price was actually what the product actually sells for normally. It's retail price is 119.99. And is currently on sale for 64.99", img: profile6 },
        ],
        direction: 'right' 
      };
    },
    computed: {
      paginatedTestimonials() {
        return this.testimonials.slice(this.currentIndex, this.currentIndex + this.testimonialsPerPage);
      },
      totalPages() {
        return Math.ceil(this.testimonials.length / this.testimonialsPerPage);
      }
    },
    methods: {
      nextTestimonials() {
        if (this.currentIndex + this.testimonialsPerPage < this.testimonials.length) {
          this.direction = 'right';
          this.currentIndex += this.testimonialsPerPage;
        } else {
          this.direction = 'right';
          this.currentIndex = 0; 
        }
      },
      prevTestimonials() {
        if (this.currentIndex > 0) {
          this.direction = 'left';
          this.currentIndex -= this.testimonialsPerPage;
        } else {
          this.direction = 'left';
          this.currentIndex = (this.totalPages - 1) * this.testimonialsPerPage; 
        }
      },
      beforeEnter(el) {
        el.style.opacity = 0;
        el.style.transform = this.direction === 'right' ? 'translateX(100%)' : 'translateX(-100%)';
      },
      enter(el, done) {
        el.offsetWidth; 
        el.style.transition = 'opacity 0.5s, transform 0.5s';
        el.style.opacity = 1;
        el.style.transform = 'translateX(0)';
        done();
      },
      leave(el, done) {
        el.style.transition = 'opacity 0.5s, transform 0.5s';
        el.style.opacity = 0;
        el.style.transform = this.direction === 'right' ? 'translateX(-100%)' : 'translateX(100%)';
        done();
      }
    }
  };
  </script>
  
  <style scoped>
  
  @import url('https://fonts.googleapis.com/css2?family=Inter:wght@400;500;700&display=swap');
  
  .testimonials-container {
    text-align: center;
    padding: 20px;
    position: relative;
  }
  
  h2 {
    font-size: 34px;
    margin-bottom: 10px;
    font-family: 'Inter', sans-serif;
  }
  
  p {
    font-size: 17px;
    margin-bottom: 20px;
    font-family: 'Inter', sans-serif;
  }
  
  .card-wrapper {
    display: flex;
    justify-content: center;
    gap: 20px;
    flex-wrap: nowrap;
    overflow: hidden;
    margin-bottom: 20px;
  }
  
  .testimonial-card {
    flex: 0 0 300px; 
    margin-right: 20px; 
    background-color: white;
    border-radius: 15px;
    padding: 20px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.15); 
    transition: box-shadow 0.3s ease;
    font-family: 'Inter', sans-serif;
  }
  
  .testimonial-group {
    display: flex;
    width: fit-content;
    transition: transform 0.5s ease;
  }
  
  .testimonial-card:hover {
    box-shadow: 0 6px 12px rgba(0, 0, 0, 0.2); 
  }
  
  .stars {
    color: orange;
    font-size: 20px;
    margin-bottom: 10px;
  }
  
  .profile {
    margin-top: 15px;
  }
  
  .profile img {
    border-radius: 50%;
    width: 60px;
    height: 60px;
    object-fit: cover;
  }
  
  .profile p {
    font-weight: bold;
    margin: 5px 0;
    font-family: 'Inter', sans-serif;
  }
  
  .profile small {
    color: gray;
    font-family: 'Inter', sans-serif;
  }
  
  .carousel {
    display: flex;
    overflow: hidden;
    width: 100%;
    justify-content: center;
    margin-bottom: 20px;
    position: relative; 
  }
  
  .carousel-controls {
    display: flex;
    justify-content: center;
    margin-top: 20px;
  }
  
  .control-btn {
    background-color: black; 
    border: 2px solid black; 
    padding: 10px;
    margin: 0 5px;
    border-radius: 50%;
    width: 55px;
    height: 55px;
    display: flex;
    justify-content: center;
    align-items: center;
    cursor: pointer;
    color: white; 
    font-size: 20px; 
    transition: background-color 0.3s, color 0.3s, border-color 0.3s; 
  }
  
  .control-btn:hover {
    background-color: white; 
    color: black; 
    border-color: black; 
  }
  
  .control-btn.light {
    border-color: #ccc;
    color: #aaa;
  }
  
  .control-btn.dark {
    border-color: #ccc;
    color: #aaa;
  }
  
  .control-btn:hover {
    opacity: 0.8;
  }
  
  .slide-enter-active, .slide-leave-active {
    transition: opacity 0.5s, transform 0.5s;
  }
  
  .slide-enter, .slide-leave-to {
    opacity: 0;
    transform: translateX(100%);
  }
  </style>