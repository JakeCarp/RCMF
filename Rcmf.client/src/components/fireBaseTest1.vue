<template>
  <ul>
    <li v-for="todo in chats" :key="todo.id" class="list-group-item">
      <span class="text-dark bg-danger">{{ todo.text }}</span>
    </li>
    
    <form @submit.prevent="post()">
      <textarea v-model="editable.text" name="" id="" cols="30" rows="10">
      </textarea>
      <button type="submit">submit</button>
    </form>
  </ul>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";
import { logger } from "../utils/Logger.js";
import Pop from "../utils/Pop.js";
import { useCollection } from "vuefire";
import { collection, doc, setDoc } from "firebase/firestore";
import { db } from "../services/FireBaseService.js";
import { set } from "@firebase/database";


export default {
  props: {},
  setup(props) {
    const editable = ref({});

    onMounted(() => {});
    watchEffect(() => {});
    const chats = useCollection(collection(db, "chats"));
 
  
 
    return {
      chats,
      editable,

      async post() {
        try {
        
          await setDoc(doc(db, "chats",id), editable.value);
          
        } catch (error) {
          Pop.error(error, "[]");
        }
      },
    };
  },
};
</script>

<style lang="scss" scoped></style>
