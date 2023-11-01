<template>
  <div class="app">
    <p>{{ name }} {{ age }}</p>
    <button @click="changeName('name')">Change name</button>
    <button @click="changeAge('999')">Change age</button>
  </div>
</template>

<script lang="ts">
import { defineComponent, reactive, ref, toRefs } from 'vue';

export default defineComponent({
  name: 'App',
  components: {},
  setup() {
    // const state = reactive({
    //   name: 'Link',
    //   age: 100 as number | string
    // }) 

    // state.name = 'surname';
    // return { ...toRefs(state)}

    const name = ref('link');
    const age = ref<number | string>(15);
    return {name, age};
  },
  methods: {
    changeName(name: string) {
      this.name = name;
    },
    changeAge(age: number | string) {
      this.age = age;
    }
  }
});
</script>

<style>
</style>
