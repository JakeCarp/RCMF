<template>
  <div class="container">
    <div class="row">
      <div class="col-md-12 text-center my-3 " v-motion-slide-visible-left>
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
        <div class="card elevation-2 border-0 p-3 d-flex justify-content-around" v-motion-slide-visible-right>
          <div class="d-flex justify-content-around">

            <a href="#tournament" class="text-dark">
              <button class="btn  p-3">
                Sign Up for Golf tournament
              </button>
            </a>
            <a href="#donate" class="text-dark">
              <button class="btn  p-3">
                Make a Donation
              </button>
            </a>
            <button class="btn p-3 " data-bs-toggle="modal" data-bs-target="#newsletterForm">
              Sign up for NewsLetter
            </button>
          </div>
        </div>

        <div class="card p-5 border-0 mt-5 roboto" v-motion-slide-visible-right>
          <figure>
            <blockquote class="blockquote">
              <p class="fs-2">
                <i class="mdi mdi-format-quote-open"></i> PREPARATION is the
                SEPARATION between being a good Firefighter - or becoming the
                BEST <i class="mdi mdi-format-quote-close"></i>
              </p>
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
          <p
            class="fs-3 mb-0 abril"
            v-motion
            :initial="{ opacity: 0, y: 100 }"
            :enter="{ opacity: 1, y: 0, scale: 1 }"
            :variants="{ custom: { scale: 2 } }"
            :hovered="{ scale: 1.2 }"
            :delay="200"
          >
            Fire Ground Training
          </p>
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
    onMounted(() => {
      hideOnScrollTest();
    });

    function hideOnScrollTest() {
      let nav = document.querySelector("#searchBar22");
      let prevScrollpos = window.scrollY;
      // console.log(["prev"], prevScrollpos);
      window.onscroll = function () {
        let currentScrollPos = window.scrollY;
        // console.log(["current"], currentScrollPos);
        if (prevScrollpos > currentScrollPos) {
          nav.style.top = "0";
          nav.style.transition = "all 0.25s ease";
          // nav.classList.remove("showOnScroll");
        } else {
          // nav.classList.add("hiddenOnScroll");
          nav.style.top = "-70px";
        }
        prevScrollpos = currentScrollPos;
      };
    }



    return {
      
    };
  },
};
</script>

<style scoped lang="scss">
#searchBar22 {
  transition: all 0.5s ease;
}
.hiddenOnScroll {
  transform: scale(3);
  transform: rotate(40deg);
}
.showOnScroll {
}


.button_container {
  position: absolute;
  left: 0;
  right: 0;
  top: 30%;
}

.description, .link {
  font-family: 'Amatic SC', cursive;
  text-align: center;
}

.description {
  font-size: 35px;
}

.btn {
  border: none;
  display: block;
  text-align: center;
  cursor: pointer;
  text-transform: uppercase;
  outline: none;
  overflow: hidden;
  position: relative;
  color: #fff;
  font-weight: 700;
  font-size: 15px;
  background-color: #222;
  padding: 17px 60px;
  margin: 0 auto;
  box-shadow: 0 5px 15px rgba(0,0,0,0.20);
}
.btn:hover{
   box-shadow: rgba(50, 50, 93, 0.25) 0px 13px 27px -5px, rgba(0, 0, 0, 0.3) 0px 8px 16px -8px;
}
.btn span {
  position: relative; 
  z-index: 1;
}

.btn:after {
  content: "";
  position: absolute;
  left: 0;
  top: 0;
  height: 490%;
  z-index: -1;
  width: 140%;
  background: #41ffc0e1;
   box-shadow: rgba(50, 50, 93, 0.25) 0px 13px 27px -5px, rgba(0, 0, 0, 0.3) 0px 8px 16px -8px;
  -webkit-transition: all .5s ease-in-out;
  transition: all .50s ease-in-out;
  -webkit-transform: translateX(-98%) translateY(-25%) rotate(45deg);
  transform: translateX(-98%) translateY(-25%) rotate(45deg);
}

.btn:hover:after {
  -webkit-transform: translateX(-9%) translateY(-25%) rotate(45deg);
  transform: translateX(-9%) translateY(-25%) rotate(45deg);
   box-shadow: rgba(50, 50, 93, 0.25) 0px 13px 27px -5px, rgba(0, 0, 0, 0.3) 0px 8px 16px -8px;
}

.link {
  font-size: 20px;
  margin-top: 30px;
}

.link a {
  color: #000;
  font-size: 25px; 
}

.image{
  height: 100vh;
  /* always scale the image to the appropriate size of your screen */
  background-size: cover;
  background-image: url(https://images.unsplash.com/photo-1575920197509-2de60ffa1b0e?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=3024&q=80);
  background-position: center;
  /* keeps the image fixed while scrolling , neat effect. */
  background-attachment: fixed; 
}
</style>
