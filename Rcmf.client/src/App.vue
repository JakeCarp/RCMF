<template>
  <header>
    <Navbar />
  </header>
  <main class="bg-light">
    <router-view />
  </main>
   <footer >
  <FooterComponent/>
  </footer>
</template>

<script>
import { computed } from 'vue'
import { AppState } from './AppState'
import FooterComponent from "./components/FooterComponent.vue"
import Navbar from './components/Navbar.vue'

export default {
  setup() {
    return {
      appState: computed(() => AppState)
    }
  },
  components: { Navbar, FooterComponent }
}
</script>
<style lang="scss">
@import "./assets/scss/main.scss";

:root{
  --main-height: calc(100vh - 32px - 64px);
}


</style>
