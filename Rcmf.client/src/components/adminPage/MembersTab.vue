<template>
<div class="container">
  <div class="row my-2 g-2">
    <div class="col-md-12" v-for="i in 10">
      <div class="card p-2 elevation-3 ">
<div>
<img src="//thiscatdoesnotexist.com" alt="" width="150" height="150">

  
</div>

      </div>
    </div>
  </div>
</div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../../AppState.js";


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
      }
    }
  }
</script>

<style lang="scss" scoped>
</style>
