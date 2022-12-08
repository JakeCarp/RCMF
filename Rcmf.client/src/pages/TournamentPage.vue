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
   
    <!-- <div
      v-masonry="containerId"
      transition-duration="0.3s"
      item-selector=".item"
    >
      <div v-masonry-tile class="item" v-for="(i,index) in images" :key="index">
        <img :src="i" alt="">
      </div>
    </div> -->
    <div class="brick my-5 p-5">
      <div class="" v-for="i in images" v-if="images">
        <div class="card my-3">
          <img :src="i" alt="" class="image-fluid">
        </div>
      </div>
    </div>
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
      getFaceBookPictures()
    });
    watchEffect(() => {});
      async function getFaceBookPictures(){
      try {
          await  firesService.getFaceBookPictures()
        } catch (error) {
          Pop.error(error,'[getFaceBookPictures]')
        }
    }
    return {
      editable,
      images: computed(() => AppState.photos),
    };
  },
  components: { TournamentSignUpForm },
};
</script>

<style lang="scss" scoped>
.brick {
  columns: 4;
}

.forcedImg{
  height: 300px;
  width: 300px;
  object-fit: cover;
}
</style>
