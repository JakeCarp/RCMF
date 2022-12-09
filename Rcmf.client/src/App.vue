<template>
  <header  class="sticky-top" id="searchBar22">
    <Navbar  />
  </header>
  <main class="bg-light overflow-hidden">
    <router-view />
  </main>
  <footer>
    <FooterComponent />
  </footer>

  <ModalComponent id="createTournament">
<TournamentCreateForm/>
  </ModalComponent>
  <ModalComponent id="newsletterForm">
<NewsLetterForm/>
  </ModalComponent>
  <ModalComponent id="activeImage">
<ActiveImage/>
  </ModalComponent>
</template>

<script>
import { computed, onMounted } from "vue";
import { AppState } from "./AppState";
import ActiveImage from "./components/ActiveImage.vue";
import FooterComponent from "./components/FooterComponent.vue";
import NewsLetterForm from "./components/forms/ NewsLetterForm.vue";
import TournamentCreateForm from "./components/forms/TournamentCreateForm.vue";
import ModalComponent from "./components/ModalComponent.vue";
import Navbar from "./components/Navbar.vue";
import { firesService } from "./services/FireBaseService.js";

export default {
  setup() {
    onMounted(() => {
     getFaceBookPictures()
    });

    // function hideOnScrollTest() {
    //   let nav = document.querySelector("#searchBar22");
    //   let prevScrollpos = window.scrollY;
    //   console.log(["prev"], prevScrollpos);
    //   window.onscroll = function () {
    //     let currentScrollPos = window.scrollY;
    //     console.log(["current"], currentScrollPos);
    //     if (prevScrollpos > currentScrollPos) {
    //       // nav.style.top="0"
    //       nav.classList.remove("showOnScroll");
    //     } else {
    //       nav.classList.add("showOnScroll");
    //       //  nav.style.top="-50px"
    //     }
    //     prevScrollpos = currentScrollPos;
    //   };
    // }
     async function getFaceBookPictures() {
      try {
        AppState.loading = false
        let ok =   await firesService.getFaceBookPictures();
        if (ok) {
          
          AppState.loading = true
     }
      } catch (error) {
        Pop.error(error, "[getFaceBookPictures]");
      }
    }
    return {
      appState: computed(() => AppState),
    };
  },
  components: { Navbar, FooterComponent, ModalComponent, TournamentCreateForm, NewsLetterForm, ActiveImage },
};
</script>
<style lang="scss">
@import "./assets/scss/main.scss";

:root {
  --main-height: calc(100vh - 32px - 85px);
}


</style>
