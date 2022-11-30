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
</template>

<script>
import { computed, onMounted } from "vue";
import { AppState } from "./AppState";
import FooterComponent from "./components/FooterComponent.vue";
import NewsLetterForm from "./components/forms/ NewsLetterForm.vue";
import TournamentCreateForm from "./components/forms/TournamentCreateForm.vue";
import ModalComponent from "./components/ModalComponent.vue";
import Navbar from "./components/Navbar.vue";

export default {
  setup() {
    onMounted(() => {
      // hideOnScrollTest();
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
    return {
      appState: computed(() => AppState),
    };
  },
  components: { Navbar, FooterComponent, ModalComponent, TournamentCreateForm, NewsLetterForm },
};
</script>
<style lang="scss">
@import "./assets/scss/main.scss";

:root {
  --main-height: calc(100vh - 32px - 64px);
}


</style>
