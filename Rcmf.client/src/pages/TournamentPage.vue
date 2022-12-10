<template>
  <div class="hero-image d-flex justify-content-center align-items-center">
    <h1
      v-motion-slide-left
      :delay="200"
      class="abril text-shadow-2 font-1 text-light page-title"
    >
      Tournament
    </h1>
  </div>

  <div class="container mt-5">
    <!-- Tournament Sign Up Form -->
    <div class="row">
      <div class="col-md-12" id="tournamentForm">
        <TournamentSignUpForm v-motion-pop />
      </div>
    </div>
    <!-- !Tournament Sign Up Form -->

    <!--Masonry Face Book Images -->
    <div
      v-masonry=""
      class="d-flex justify-content-center my-5 ms-5"
      transition-duration="0.3s"
      item-selector=".item"
    >
      <div
        v-masonry-tile
        class="item"
        v-for="(i, index) in images"
        :key="index"
      >
        <div
          class="card border-0 m-3 hover-2 elevation-6"
          @click="setActiveImage(i)"
          data-bs-toggle="modal"
          data-bs-target="#activeImage"
        >
          <img :src="i" alt="" class="img-fluid" />
        </div>
      </div>
    </div>
    <!-- !Masonry Face Book Images -->
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";

import TournamentSignUpForm from "../components/forms/TournamentSignUpForm.vue";
import LoadingAnimation from "../components/LoadingAnimation.vue";

export default {
  props: {},
  setup(props) {
    const editable = ref({});
    onMounted(() => {});
    watchEffect(() => {});

    return {
      editable,
      images: computed(() => AppState.photos),
      loading: computed(() => AppState.loading),
      setActiveImage(image) {
        AppState.activeImage = image;
      },
    };
  },
  components: { TournamentSignUpForm, LoadingAnimation, LoadingAnimation },
};
</script>

<style lang="scss" scoped>
.page-title {
  font-size: 7rem;
}
.hero-image {
  height: 30vh;
  /* always scale the image to the appropriate size of your screen */
  background-size: cover;
  background-image: url(https://idgolf.com/wp-content/uploads/2019/01/IMG_20180528_082705.jpg);
  background-position: center;
  /* keeps the image fixed while scrolling , neat effect. */
  background-attachment: fixed;
}

.item {
  max-width: 300px;
}
</style>
