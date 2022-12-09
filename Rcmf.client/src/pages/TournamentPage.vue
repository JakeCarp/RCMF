<template>
  <div class="container">
    <div class="my-3 text-center">
      <h1 class="abril display-3 text-shadow-2">Tournament</h1>
    </div>
    <!-- <FireBaseTest1/> -->

    <div class="row">
      <div class="col-md-12">
        <!-- <FireBaseTest1/> -->
      </div>
      <div class="col-md-12" id="tournamentForm">
        <TournamentSignUpForm />
      </div>
    </div>
    <div class=""></div>

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
      <div class="card rounded-1 border-0 m-3  hover-2 elevation-6" @click="setActiveImage(i)">

        <img :src="i" alt="" class="img-fluid rounded-1"/>
      </div>
      </div>
    </div>
    <!-- <div class="brick my-5 ">
      <div class="" v-for="(i,index) in images" :key="index" v-if="images">
        <div class="card border-0 bg-transparent my-3">
          <img :src="i" alt="" class=" rounded-1 elevation-2 hover-2  ">
        </div>
      </div>
    </div> -->
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";

import TournamentSignUpForm from "../components/forms/TournamentSignUpForm.vue";
import { firesService } from "../services/FireBaseService.js";
import { logger } from "../utils/Logger.js";
import Pop from "../utils/Pop.js";

export default {
  props: {},
  setup(props) {
    const editable = ref({});
    onMounted(() => {
      getFaceBookPictures();
    });
    watchEffect(() => {});
    async function getFaceBookPictures() {
      try {
        await firesService.getFaceBookPictures();
      } catch (error) {
        Pop.error(error, "[getFaceBookPictures]");
      }
    }
    return {
      editable,
      images: computed(() => AppState.photos),
      setActiveImage(image){
         AppState.activeImage = image
      }
    };
  },
  components: { TournamentSignUpForm },
};
</script>

<style lang="scss" scoped>

.item{
  max-width: 400px;
}
.brick {
  columns: 4;
}

.forcedImg {
  height: 300px;
  width: 300px;
  object-fit: cover;
}
</style>
