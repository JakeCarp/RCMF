<template>
<div class="row green2">
  <div>
    <svg id="" preserveAspectRatio="xMidYMax meet" class="svg-separator sep4" viewBox="0 0 1600 200" style="display: block;" data-height="200">
<polygon class="" style="fill: rgb(27, 188, 155);" points="886,86 800,172 714,86 -4,86 -4,204 1604,204 1604,86 "></polygon> 
<polygon class="" style="opacity: 1;fill: #0e9382;" points="800,172 886,86 900,86 800,186 700,86 714,86 "></polygon> 
<polygon class="" style="opacity: 1;fill: #14a084;" points="800,162 876,86 888,86 800,174 712,86 724,86 "></polygon></svg>
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
      }
    }
  }
</script>

<style lang="scss" scoped>
.row{
  width:100%;

  padding:0;
  margin:0;
  display: flex;
  justify-content: center;
  flex-direction: column;
  position:relative;
}
.svg-separator{
  display: block;
  background: 0 0;
  position: absolute;
  left: 0;
  right: 0;
  top: 0;
  z-index: 9;
  -webkit-transform: translateY(-100%) translateY(2px);
  transform: translateY(-100%) translateY(2px);
  width: 100%;
}
.svg-separator.bottom{
  top: auto;
  bottom: 0;
}.sep4 {
  transform: translateY(-100%) translateY(2px) scale(1,1);
  transform-origin: top;
}

</style>
