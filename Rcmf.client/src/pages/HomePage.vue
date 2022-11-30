<template>
  <div class="container">
    <div class="row">
      <div class="col-md-12 text-center my-3" v-motion-slide-visible-left>
        <h1 class="abril display-1">Randy Carpenter Memorial Foundation</h1>
      </div>
      <div class="col-md-4" v-motion-slide-visible-left>
        <img
          src="https://scontent-fml2-1.xx.fbcdn.net/v/t39.30808-6/309310916_462265265948741_4507589102631506885_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=e3f864&_nc_ohc=be58jBQBO1YAX8vF_jZ&_nc_ht=scontent-fml2-1.xx&oh=00_AfAWa5YCuvIMUQyprPmIj0aAF6LnbOzoHJxTClaX3RRVHQ&oe=638C58B3"
          alt=""
          class="img-fluid rounded elevation-6"
        />
      </div>
      <div class="col-md-8" v-motion-slide-visible-right>
        <div class="card elevation-2 border-0 p-3" v-motion-slide-visible-right>
          <a href="#tournament">
            <button class="btn btn-outline-dark p-3">
              Sign Up for Golf tournament
            </button>
          </a>
        </div>

        <div class="card p-5  border-0 mt-5 roboto" v-motion-slide-visible-right>
 
<figure>
  <blockquote class="blockquote">
    <p class="fs-2"><i class="mdi mdi-format-quote-open"></i> PREPARATION
is the SEPARATION
between being a
good Firefighter
- or becoming the BEST <i class="mdi mdi-format-quote-close"></i></p>
  </blockquote>
  <figcaption class="blockquote-footer fs-5 mt-2 text-center">
    Captain Randy Carpenter
  </figcaption>
</figure>

        </div>
      </div>
    </div>
    <div class="row my-4">
      <div class="col-md-12" v-motion-slide-visible-right>
        <h2 class="display-4 abril">Providing Firefighters With..</h2>
      </div>
    </div>
    <div class="row justify-content-evenly my-5">
      <div class="col-md-3" v-motion-slide-visible-right>
        <img
          src="https://images.unsplash.com/photo-1633092228879-d6a88c22e7bc?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1374&q=80"
          alt=""
          class="img-fluid rounded elevation-6"
        />
        <div class="">
          <p class="fs-3 mb-0 abril" v-motion
    :initial="{ opacity: 0, y: 100 }"
    :enter="{ opacity: 1, y: 0, scale: 1 }"
    :variants="{ custom: { scale: 2 } }"
    :hovered="{ scale: 1.2 }"
    :delay="200">  Fire Ground Training</p>
          <p>Through Hands On Experience</p>
        </div>
      </div>
      <div class="col-md-3" v-motion-slide-visible-right>
        <img
          src="//thiscatdoesnotexist.com"
          alt=""
          class="img-fluid rounded elevation-6"
        />
      </div>
      <div class="col-md-3" v-motion-slide-visible-right>
        <img
          src="//thiscatdoesnotexist.com"
          alt=""
          class="img-fluid rounded elevation-6"
        />
      </div>
    </div>
    <div class="row justify-content-center">
      <div class="col-md-12 text-center" v-motion-slide-visible-right>
        <h3 class="abril display-5 my-5">Our Sponsors</h3>
      </div>
      <div class="col-md-10 my-5" v-motion-slide-visible-right>
        <div class="card border-0">
          <img
            src="https://images.unsplash.com/photo-1666872173125-785f3b135494?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1169&q=80"
            alt=""
            class="img-fluid rounded elevation-6"
          />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { onMounted } from "vue";



export default {
  setup() {
    onMounted(()=>{
    hideOnScrollTest()
    })

      function hideOnScrollTest() {
      let nav = document.querySelector("#searchBar22");
      let prevScrollpos = window.scrollY;
      console.log(["prev"], prevScrollpos);
      window.onscroll = function () {
        let currentScrollPos = window.scrollY;
        console.log(["current"], currentScrollPos);
        if (prevScrollpos > currentScrollPos) {
          nav.style.top="0"
          nav.style.transition="all 0.25s ease"
          nav.classList.remove("showOnScroll");
        } else {
          nav.classList.add("hiddenOnScroll");
           nav.style.top="-70px"
        }
        prevScrollpos = currentScrollPos;
      };
    }
    return {};
  },
};
</script>

<style scoped lang="scss">

#searchBar22{
  transition: all 0.5s ease;
}
.hiddenOnScroll {
  transform: scale(3);
transform: rotate(40deg);

}
.showOnScroll {



}

</style>
