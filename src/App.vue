<template>
  <nav class="text-center p-5">
    <router-link to="/">Home</router-link> |
    <router-link :to="{name: 'aboutt'}">About</router-link>
  </nav>
  <router-view/>
  <div class="text-center p-5">
    <button @click="redirect">Redirect</button>
    <button @click="back">Go back</button>
    <button @click="forward">Go forward</button>
  </div>
</template>

<script lang="ts">
import { defineComponent} from 'vue';
import { useRouter } from 'vue-router';

export default defineComponent({
  name: 'App',
  setup() {
    const router = useRouter();

    const redirect = () => { router.push({name: 'home'}) }
    const back = () => { router.go(-1) }
    const forward = () => { router.go(1) }

    return { redirect, back, forward }
  }
});
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
}

nav a {
  font-weight: bold;
  color: #2c3e50;
}

nav a.router-link-exact-active {
  color: #42b983;
}
</style>
