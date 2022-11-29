<template>
<div class="container">
  <div class="my-3 text-center">
    <h1 class="abril display-3">Tournament</h1>
  </div>
<FireBaseTest1/>
  <div class="row">
    <div class="col-md-12">
    <FilePicker/>
    </div>
    <div class="col-md-12">
     <TournamentSignUpForm/>
    </div>
  </div>
<div class="">

</div>
  


<!-- <div v-masonry="containerId" transition-duration="0.3s" item-selector=".item">
    <div v-masonry-tile class="item" v-for="(item, index) in blocks">
      
    </div>
</div> -->


</div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";
import FireBaseTest1 from "../components/fireBaseTest1.vue";
import TournamentSignUpForm from "../components/TournamentSignUpForm.vue";
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
    components: { TournamentSignUpForm, FireBaseTest1 }
}
</script>

<style lang="scss" scoped>

.brick{
columns: 4;
}
</style>
