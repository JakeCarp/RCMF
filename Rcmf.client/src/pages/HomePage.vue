<template>
  <div class="hero-image d-flex align-items-center justify-content-center">
    <div class="col-md-12 text-center" v-motion-slide-left>
      <h1 class="hero-text font-1 text-light px-5 text-shadow-2">
        Randy Carpenter Memorial Foundation
      </h1>
    </div>
  </div>
  <div class="container-fluid mt-5">
    <!-- section1 -->
    <section>
      <div class="row">
        <div
          class="col-md-5 d-flex align-items-center justify-content-center"
          v-motion-slide-left
          :delay="200"
        >
          <img
            src="https://scontent-fml2-1.xx.fbcdn.net/v/t1.18169-9/154320_466267117079_6118989_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=cdbe9c&_nc_ohc=WDMrIYo_jxIAX-lfkcp&_nc_ht=scontent-fml2-1.xx&oh=00_AfDZpQIltUKPbi9QmLLR50ZFMIYJ2UPHLmUZEsWoVSae5w&oe=63B8D3E0"
            alt=""
            class="img-fluid image-2 hover-2 rounded elevation-6"
          />
        </div>
        <div class="col-md-7" v-motion-slide-right :delay="200">
          <div
            class="card border-0 p-3 d-flex justify-content-around"
            v-motion-slide-right
            :delay="200"
          >
            <div class="d-md-flex">
              <a href="#tournament" class="text-dark mx-auto">
                <button class="btn p-3">Sign Up for Golf tournament</button>
              </a>
              <a href="#donate" class="text-dark">
                <button class="btn p-3 my-3 my-md-0">Make a Donation</button>
              </a>
              <button
                class="btn p-3"
                data-bs-toggle="modal"
                data-bs-target="#newsletterForm"
              >
                Sign up for NewsLetter
              </button>
            </div>
          </div>

          <div
            class="card p-md-5 border-0 mt-5 roboto"
            v-motion-slide-right
            :delay="300"
          >
            <figure class="">
              <!-- <p class="fs-2">
              <i class="mdi mdi-format-quote-open"></i> PREPARATION is the
              SEPARATION between being a good Firefighter - or becoming the
              BEST <i class="mdi mdi-format-quote-close"></i>
            </p> -->

              <blockquote class="p-5">
                <p class="fs-3 text-center">
                  <b class=""> PREPARATION</b>
                  is the <b>SEPARATION</b> between being a good Firefighter - or
                  becoming the <b>BEST</b>
                </p>
                <figcaption class="blockquote-footer fs-5 mt-5 text-center">
                  Captain Randy Carpenter
                </figcaption>
              </blockquote>
            </figure>
          </div>
        </div>
      </div>
    </section>
    <!--! section1 -->

    <!-- section2 -->
    <section>
      <div class="row justify-content-evenly my-5 bg-primary darken-10">
        <div class="col-md-12 my-5" v-motion-slide-visible-left>
          <h2 class="display-4 font-1">Providing Firefighters With</h2>
        </div>
        <div class="col-md-3 my-3" v-motion-slide-visible-left>
          <img
            src="https://images.unsplash.com/photo-1633092228879-d6a88c22e7bc?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1374&q=80"
            alt=""
            class="three-images hover-2 img-fluid rounded"
          />
          <div class="my-3">
            <p class="fs-3 mb-0 font-1">Fire Ground Training</p>
            <p>Through Hands On Experience</p>
          </div>
        </div>
        <div class="col-md-5 my-3" v-motion-slide-visible-left>
          <img
            src="https://scontent-fml2-1.xx.fbcdn.net/v/t31.18172-8/13483319_10154795226862080_1434242293369889234_o.jpg?_nc_cat=110&ccb=1-7&_nc_sid=730e14&_nc_ohc=ZiXSMZmPGfQAX8jdQEq&_nc_ht=scontent-fml2-1.xx&oh=00_AfCdtEC9PsQ9xnwgPpD-7l2-LxZ58X2XRdFom-CA0ILBPg&oe=63B0634F"
            alt=""
            class="three-images hover-2 img-fluid rounded elevation-6"
          />
          <div class="my-3">
            <p class="fs-3 mb-0 font-1">Lorem ipsum dolor</p>
            <p>
              Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ipsa.
            </p>
          </div>
        </div>
        <div class="col-md-3 my-3" v-motion-slide-visible-left>
          <img
            src="https://scontent-fml2-1.xx.fbcdn.net/v/t31.18172-8/13495663_10154795225037080_7692198579030023972_o.jpg?_nc_cat=102&ccb=1-7&_nc_sid=730e14&_nc_ohc=zOC_iireDwkAX_XgKG1&_nc_ht=scontent-fml2-1.xx&oh=00_AfD4Xk6C_-Yxv8sB8rNXS5za9ukRueRvCs9eEdLOF43Tsg&oe=63B07750"
            alt=""
            class="three-images hover-2 img-fluid rounded elevation-6"
          />
          <div class="my-3">
            <p class="fs-3 font-1 mb-0">Lorem ipsum dolor</p>
            <p>
              Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ipsa.
            </p>
          </div>
        </div>
      </div>
    </section>
    <!-- !section2 -->

    <!-- section3 -->
    <section>
      <div class="row justify-content-center">
        <div class="col-md-12 text-center" v-motion-slide-visible-right>
          <h3 class="font-1 display-3">Sponsors</h3>
        </div>
        <div class="col-md-8 mb-5" v-motion-slide-visible-right>
          <div
            id="carouselExampleControls"
            class="carousel slide"
            data-bs-ride="carousel"
          >
            <div class="carousel-inner elevation-6 rounded-1">
              <div class="carousel-item active">
                <img
                  src="https://images.unsplash.com/photo-1524856781660-e5c92f4ac62a?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                  class="d-block w-100"
                  alt="..."
                />
              </div>
              <div class="carousel-item">
                <img
                  src="https://images.unsplash.com/photo-1614338577197-5812cb856df7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1169&q=80."
                  class="d-block w-100"
                  alt="..."
                />
              </div>
              <div class="carousel-item">
                <img
                  src="https://images.unsplash.com/photo-1504667290505-eee11f23905a?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                  class="d-block w-100"
                  alt="..."
                />
              </div>
            </div>
            <button
              class="carousel-control-prev"
              type="button"
              data-bs-target="#carouselExampleControls"
              data-bs-slide="prev"
            >
              <span
                class="carousel-control-prev-icon"
                aria-hidden="true"
              ></span>
              <span class="visually-hidden">Previous</span>
            </button>
            <button
              class="carousel-control-next"
              type="button"
              data-bs-target="#carouselExampleControls"
              data-bs-slide="next"
            >
              <span
                class="carousel-control-next-icon"
                aria-hidden="true"
              ></span>
              <span class="visually-hidden">Next</span>
            </button>
          </div>
        </div>
      </div>
    </section>
    <!-- !section3 -->
  </div>
</template>

<script>
import { onMounted } from "vue";
import { firesService } from "../services/FireBaseService.js";
import Pop from "../utils/Pop.js";

export default {
  setup() {
    onMounted(() => {
      hideOnScrollTest();
      // getFaceBookPictures();
    });

    async function getFaceBookPictures() {
      try {
        await firesService.getFaceBookPictures();
      } catch (error) {
        Pop.error(error, "[getFaceBookPictures]");
      }
    }

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
          nav.style.top = "-85px";
        }
        prevScrollpos = currentScrollPos;
      };
    }

    return {};
  },
};
</script>

<style scoped lang="scss">
.image-2 {
  height: 600px;
  object-fit: cover;
}
.hero-image {
  height: 40vh;
  /* always scale the image to the appropriate size of your screen */
  background-size: cover;
  background-image: url(https://images.unsplash.com/photo-1524856781660-e5c92f4ac62a?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80);
  background-position: center top;
  /* keeps the image fixed while scrolling , neat effect. */
  background-attachment: fixed;

  //when screen is 768px OR LESS
  @media only screen and (max-width: 768px) {
    height: 30vh;
  }
  .hero-text {
    font-size: 7rem;

    //when screen is 768px OR LESS
    @media only screen and (max-width: 768px) {
      font-size: 3rem;
    }
  }
}

.three-images {
  height: 30rem;
  width: auto;
  object-fit: cover;
}
#searchBar22 {
  transition: all 0.5s ease;
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
  box-shadow: 0 5px 15px rgba(0, 0, 0, 0.2);
  transition: all 0.5s ease;
}
.btn:hover {
  box-shadow: rgba(50, 50, 93, 0.25) 0px 13px 27px -5px,
    rgba(0, 0, 0, 0.3) 0px 8px 16px -8px;
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
  box-shadow: rgba(50, 50, 93, 0.25) 0px 13px 27px -5px,
    rgba(0, 0, 0, 0.3) 0px 8px 16px -8px;
  -webkit-transition: all 0.5s ease-in-out;
  transition: all 0.5s ease-in-out;
  -webkit-transform: translateX(-98%) translateY(-25%) rotate(45deg);
  transform: translateX(-98%) translateY(-25%) rotate(45deg);
}

.btn:hover:after {
  -webkit-transform: translateX(-9%) translateY(-25%) rotate(45deg);
  transform: translateX(-9%) translateY(-25%) rotate(45deg);
  box-shadow: rgba(50, 50, 93, 0.25) 0px 13px 27px -5px,
    rgba(0, 0, 0, 0.3) 0px 8px 16px -8px;
}

blockquote {
  position: relative;
  margin: 40px 0;
  border: 2px solid white;
  box-shadow: 2px 2px 4px hsl(0 0% 0% / 20%);
  text-indent: 1.6em;
  transition: all 0.5s ease;
}

blockquote::before {
  content: "";
  pointer-events: none;
  position: absolute;
  z-index: 1;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  border-radius: var(--border-rad);
  box-shadow: 0 3px 1px -2px rgba(0, 0, 0, 0.2), 0 2px 2px 0 rgba(0, 0, 0, 0.14),
    0 1px 5px 0 rgba(0, 0, 0, 0.12);
}

blockquote::after {
  content: "???";
  position: absolute;
  z-index: 1;
  left: 50%;
  top: -2px;
  transform: translate(-50%, -50%);
  width: 1.3em;
  height: 1.3em;
  background: white;
  box-shadow: 0 4px 5px -1px hsla(0 0% 0% / 20%);
  border-radius: 999px;
  display: grid;
  place-content: center;
  padding-top: 0.5em;
  color: var(--accent-color);
  font-size: 36px;
  font-style: normal;
  text-indent: 0;
}

blockquote:hover {
  transition: all 0.5s ease;
  box-shadow: rgba(50, 50, 93, 0.25) 0px 13px 27px -5px,
    rgba(0, 0, 0, 0.3) 0px 8px 16px -8px;
}

@media screen and (min-width: 768px) {
  .hero-text {
    font-size: 2rem;
    color: #000;
  }
}
</style>
