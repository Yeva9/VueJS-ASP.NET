<template>
  <div class="app container">
    <header>
      <div class="title">
        <img src="../assets/logo.svg" alt="site logo">
        <h1> Hyrule Jobs </h1>
      </div>
      <div class="order">
        <button type="button" class="btn btn-warning btn-lg" @click="handleClick('title')">Order by title</button>
        <button type="button" class="btn btn-warning btn-lg" @click="handleClick('salary')">Order by salary</button>
        <button type="button" class="btn btn-warning btn-lg" @click="handleClick('location')">Order by location</button>
      </div>
    </header>

    <AddJob/>
    <JobsList :jobs="jobs" :order="order"/> 
  </div>
</template>
<script lang="ts">
import { defineComponent, ref } from 'vue';
import JobsList from '../components/JobsList.vue';
import AddJob from '../components/AddJob.vue';
import Job from '../types/Job';
import OrderTerm from '../types/OrderTerm';

export default defineComponent({
  name: 'App',
  components: { JobsList, AddJob },
  setup() {
    const addJobUrl = ref("https://blog.logrocket.com/use-vue-js-event-emitters-modify-component-data/")

    const jobs = ref<Job[]>([
      { title: 'farm worker', location: 'lon lon ranch', salary: 30000, description: "111", id: '1', isFav: false },
      { title: 'quarryman', location: 'death mountain', salary: 40000, description: "111",  id: '2', isFav: false },
      { title: 'flute player', location: 'the lost woods', salary: 35000, description: "111",  id: '3', isFav: false },
      { title: 'fisherman', location: 'lake hylia', salary: 21000, description: "111",  id: '4', isFav: false },
      { title: 'prison guard', location: 'gerudo valley', salary: 32000, description: "111",  id: '5', isFav: false }
    ]);

    const order = ref<OrderTerm>('title'); // current state

    const handleClick = (term: OrderTerm) => {
      order.value = term;
    }

    return { 
      jobs,
      handleClick,
      order,
      addJobUrl
     };
  },
  methods: {}
});
</script>

<style>
header {
    text-align: center;
  }
  header .order {
    margin-top: 20px;
  }
  button {
    margin: 0 10px;
    color: #119ec9;
    border: 2px solid #1195c9;
    background: #e9f7ff;
    padding: 8px 16px;
    border-radius: 4px;
    cursor: pointer;
    font-weight: bold;
  }
  header .title{
    display: flex;
    justify-content: center;
  }
  header img {
    width: 60px;
    margin-right: 20px;
  }
  header h1 {
    font-size: 3em;
  }
</style>

