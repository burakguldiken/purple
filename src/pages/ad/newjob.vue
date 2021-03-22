<template>
  <div>
      <br><br>
          <div class="container-fluid">
            <div class="row">
              <div class="col-sm-12">
                <px-card>
                  <div slot="with-padding">
                    <div class="form theme-form">
                      <div class="row">
                        <div class="col-6">
                          <div class="form-group">
                            <label>Advertisement Title</label>
                            <input class="form-control" type="text" placeholder="Advertisement name">
                          </div>
                        </div>
                        <div class="col-6">
                          <div class="form-group">
                            <label>Owner</label>
                            <input class="form-control" type="text" placeholder="Company Or Owner Name">
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col">
                          <div class="form-group">
                            <label>Basic Description</label>
                            <textarea placeholder="Basic project description..." class="form-control" id="exampleFormControlTextarea4" rows="3"></textarea>
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col-xl-4" >
                          <px-card title="Responsibilities" :actions="false" class="border-style">
                            <div slot="with-padding">
                              <div class="todo">
                                <div class="todo-list-wrapper">
                                  <div class="todo-list-container">
                                    <div class="todo-list-body">
                                      <ul id="todo-list">
                                        <li  v-for="(todo,index) in todolist" :key="index" class="task" :class="{'completed':todo.status == 'complete'}">
                                          <div class="task-container">
                                            <h4 class="task-label"> {{todo.title}} </h4>
                                            <span class="task-action-btn">
                                                <span @click="tododelete(todo.id)" class="action-box large delete-btn" title="Delete Task"><i class="icon"><i class="icon-trash"></i></i></span>
                                            </span>
                                          </div>
                                        </li>
                                      </ul>
                                    </div>

                                    <div class="todo-list-footer">
                                      <div class="add-task-btn-wrapper"><span class="add-task-btn">
                                          <button  @click='addtask =! addtask' class="btn btn-primary btn-sm" :class="{'d-none':addtask}"><i class="icon-plus"></i> Add</button></span></div>
                                      <div class="new-task-wrapper " :class="{'visible':addtask}">
                                        <textarea v-on:keyup.enter="addnewtask" v-model="task" id="new-task" placeholder="Enter new responsibility. . ."></textarea>
                                        <span @click='addtask = false'  class="btn btn-danger cancel-btn btn-sm" id="close-task-panel">Close</span>
                                        <span @click="addnewtask()" class="btn btn-primary ml-3 add-new-task-btn btn-sm" id="add-task">Add Task</span>
                                      </div>
                                    </div>

                                  </div>
                                </div>
                                <div>
                                  <notifications classes="task" group="Todolist" />
                                </div>
                              </div>
                            </div>
                          </px-card>
                        </div>
                        <div class="col-xl-4">
                          <px-card title="Requirements" :actions="false" class="border-style">
                            <div slot="with-padding">
                              <div class="todo">
                                <div class="todo-list-wrapper">
                                  <div class="todo-list-container">
                                    <div class="todo-list-body">
                                      <ul id="todo-list">
                                        <li  v-for="(todo,index) in todolist" :key="index" class="task" :class="{'completed':todo.status == 'complete'}">
                                          <div class="task-container">
                                            <h4 class="task-label"> {{todo.title}} </h4>
                                            <span class="task-action-btn">
                                                <span @click="tododelete(todo.id)" class="action-box large delete-btn" title="Delete Task"><i class="icon"><i class="icon-trash"></i></i></span>
                                            </span>
                                          </div>
                                        </li>
                                      </ul>
                                    </div>

                                    <div class="todo-list-footer">
                                      <div class="add-task-btn-wrapper"><span class="add-task-btn">
                                          <button  @click='addtask =! addtask' class="btn btn-primary btn-sm" :class="{'d-none':addtask}"><i class="icon-plus"></i> Add</button></span></div>
                                      <div class="new-task-wrapper " :class="{'visible':addtask}">
                                        <textarea v-on:keyup.enter="addnewtask" v-model="task" id="new-task" placeholder="Enter new requirement. . ."></textarea>
                                        <span @click='addtask = false'  class="btn btn-danger cancel-btn btn-sm" id="close-task-panel">Close</span>
                                        <span @click="addnewtask()" class="btn btn-primary ml-3 add-new-task-btn btn-sm" id="add-task">Add Task</span>
                                      </div>
                                    </div>

                                  </div>
                                </div>
                                <div>
                                  <notifications classes="task" group="Todolist" />
                                </div>
                              </div>
                            </div>
                          </px-card>
                        </div>
                        <div class="col-xl-4">
                          <px-card title="Required Skills" :actions="false" class="border-style">
                            <div slot="with-padding">
                              <div class="todo">
                                <div class="todo-list-wrapper">
                                  <div class="todo-list-container">
                                    <div class="todo-list-body">
                                      <ul id="todo-list">
                                        <li  v-for="(todo,index) in todolist" :key="index" class="task" :class="{'completed':todo.status == 'complete'}">
                                          <div class="task-container">
                                            <h4 class="task-label"> {{todo.title}} </h4>
                                            <span class="task-action-btn">
                                                <span @click="tododelete(todo.id)" class="action-box large delete-btn" title="Delete Task"><i class="icon"><i class="icon-trash"></i></i></span>
                                            </span>
                                          </div>
                                        </li>
                                      </ul>
                                    </div>

                                    <div class="todo-list-footer">
                                      <div class="add-task-btn-wrapper"><span class="add-task-btn">
                                          <button  @click='addtask =! addtask' class="btn btn-primary btn-sm" :class="{'d-none':addtask}"><i class="icon-plus"></i> Add</button></span></div>
                                      <div class="new-task-wrapper " :class="{'visible':addtask}">
                                        <textarea v-on:keyup.enter="addnewtask" v-model="task" id="new-task" placeholder="Enter new require skill. . ."></textarea>
                                        <span @click='addtask = false'  class="btn btn-danger cancel-btn btn-sm" id="close-task-panel">Close</span>
                                        <span @click="addnewtask()" class="btn btn-primary ml-3 add-new-task-btn btn-sm" id="add-task">Add Task</span>
                                      </div>
                                    </div>

                                  </div>
                                </div>
                                <div>
                                  <notifications classes="task" group="Todolist" />
                                </div>
                              </div>
                            </div>
                          </px-card>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col">
                          <div class="form-group">
                            <label>Upload project image</label>
                            <vue-dropzone id="singledropzone" :options="singledropzoneOptions" class="dropzone digits"></vue-dropzone>
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col">
                          <div class="form-group mb-0"><a class="btn btn-primary btn-sm mr-3" href="#">Create</a><a class="btn btn-danger btn-sm" href="#">Cancel</a></div>
                        </div>
                      </div>
                    </div>
                  </div>
                </px-card>
              </div>
            </div>
          </div>
  </div>
</template>
<script>
import Datepicker from 'vuejs-datepicker';
import vue2Dropzone from 'vue2-dropzone'
import 'vue2-dropzone/dist/vue2Dropzone.min.css'
import { mapState } from "vuex";
export default {
  name:'todo',
	data(){
		return{
			singledropzoneOptions:{
          url:"http://localhost:8080",
          thumbnailWidth: 150,
          maxFiles:1,
          maxFilesize: 2,
          addRemoveLinks: true,
          dictDefaultMessage:"<i class='icon-cloud-up'></i><h6>Drop files here or click to upload.</h6><span>(This is just a demo dropzone. Selected files are <strong>not</strong> actually uploaded.)</span>"
          },
      addtask :false,
      task:''
		}
	},
	components: {
    vueDropzone: vue2Dropzone,
    Datepicker
	},
  computed: {
      ...mapState({
        todolist: state => state.todo.todo,
      })
    },
  methods:{
      taskcomplete(id,status)
      {
        this.$store.dispatch('todo/taskcomplete', id)

        if(status != "complete")
          this.$toasted.show(" tasks marked as complete.", {theme: 'outline', type: 'success', duration: 2000});
           else
          this.$toasted.show(" tasks marked as incomplete.", {theme: 'outline', type: 'error', duration: 2000});

      },
      alltaskcomplete()
      {
        this.$store.dispatch('todo/alltaskcomplete',this.markallread)
        this.markallread =! this.markallread
        if(this.markallread)
          this.$toasted.show("All tasks marked as Incomplete.",{theme:'outline', type : 'error',duration:2000});
        else
         this.$toasted.show("All tasks marked as complete.",{theme:'outline', type : 'success',duration:2000});

      },
      tododelete(id)
      {
        this.$store.dispatch('todo/tododelete', id)
        this.$toasted.show("Task has been deleted.",{theme:'outline', type : 'success',duration:2000});
      },
      addnewtask()
      {
        if(this.task != '')
        {
          this.$store.dispatch('todo/addtodo', this.task)
          this.task = ''
          this.addtask = false
          var container = this.$el.querySelector(".todo-list-body");
          setTimeout(function () {
            container.scrollBy({ top: 200, behavior: 'smooth' });
          }, 310)
          this.$toasted.show("Task list is updated.",{theme:'outline', type : 'success',duration:2000});
        }

      }
    }
}
</script>
