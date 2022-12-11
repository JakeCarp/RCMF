<template>
  <div  class="hero-image text-center d-flex align-items-center justify-content-center">
    <h1  v-motion-slide-left class="text-center text-light  font-1 ">Become A Sponsor</h1>
  </div>
  <div class="container">
  
    <div class="row">
      <div class="col-md-12">
        <SponsorForm   />


      </div>
    </div>


  </div>


</template>


<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";
import SponsorForm from "../components/forms/SponsorForm.vue";
import { logger } from "../utils/Logger.js"
import Pop from "../utils/Pop.js";

export default {
  props: {},
  setup(props) {
    const editable = ref({});
    onMounted(() => {
    });
    watchEffect(() => { });
    return {
      editable,
    };
  },
  components: { SponsorForm }
}
</script>

<style lang="scss" scoped>
.hero-image {
  background-image: url(https://images.unsplash.com/photo-1531431199010-1f9985f83baa?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1771&q=80);
  height: 400px;
  width: 100vw;
  background-size: cover;
  background-position: center;
  background-attachment: fixed;
  border-radius: 4px;
}

.font-1{
font-size: 7rem;
}
</style>
