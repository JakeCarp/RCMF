<template>
<div class="modal-body border-0 bg-transparent">
<div class="card border-0 bg-transparent">
    <img :src="image" alt="" class="image-fluid rounded elevation-6">
</div>
</div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";
import { logger } from "../utils/Logger.js"
import Pop from "../utils/Pop.js";

export default {
props:{

       },
  setup(props) {
    const editable = ref({});
    
    onMounted(() => {

    });
    watchEffect(() => {});

    return {
      editable,
      image:computed(()=> AppState.activeImage)
      }
    }
  }
</script>

<style lang="scss" scoped>

img{
  transform: scale(2.25);
}
</style>
