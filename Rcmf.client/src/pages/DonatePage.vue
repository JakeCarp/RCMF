<template>
  <div class="heroImg d-flex align-items-center justify-content-center">
    <div class="col-md-12 text-center" v-motion-slide-left :delay="300">
        <h1 class="display-1 font-1 text-light"> Donations</h1>
        <h2 class="font-1 text-light fs-1 "> Support the bravest people we know</h2>
    </div>
  </div>
  <div class="container">
    <div class="row justify-content-center">
   
      <!-- <div class="col-md-12 heroImg elevation-6 mb-5 mt-2">

      </div> -->
      <div class="row my-5">
        <div class="col-md-6">
<DonateForm/>
        </div>
        <div class="col-md-6">
<div class="card p-4">
  <p class="title fs-3 text-center" >Title</p>
  <p class="fs-5">Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat aliquam necessitatibus pariatur laboriosam temporibus facilis? Veritatis omnis pariatur vitae quidem vel sed amet esse, molestiae unde alias distinctio eveniet exercitationem similique illo. Dolores eaque natus deleniti modi vero quisquam quam cumque.
  </p>
</div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";
import DonateForm from "../components/forms/DonateForm.vue";
import { firesService } from "../services/FireBaseService.js";

import { logger } from "../utils/Logger.js";
import Pop from "../utils/Pop.js";

export default {
    props: {},
    setup(props) {
        const editable = ref("");
        onMounted(() => {
       
        });
   
        return {
            editable,
            components: { DonateForm, DonateForm }
        };
    },
    components: { DonateForm }
}
</script>

<style lang="scss" scoped>

.heroImg{
  background-image: url(https://images.unsplash.com/photo-1544027993-37dbfe43562a?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1770&q=80);
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
