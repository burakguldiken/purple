<template>
  <div>
    <br><br>
    <div class="container-fluid p-l-50 m-t-30">
      <div class="row p-l-50">
        <div class="col-12 call-chat-body">
          <div class="card shadow">
            <div class="card-body p-0">
              <div class="row chat-box">
                  <div class="col call-chat-sidebar col-sm-12">
            <div class="card-body chat-body" style="border-right:1px solid #f4f4f4">
              <div class="chat-box">
                <div class="chat-left-aside">
                  <div class="people-list custom-scrollbar" id="people-list">
                    <div class="search">
                      <form class="theme-form">
                        <div class="form-group">
                          <input
                            v-model="search"
                            v-on:keyup="setSerchUsers"
                            class="form-control"
                            type="text"
                            placeholder="Kullanıcı Ara"
                          /><i class="fa fa-search"></i>
                        </div>
                      </form>
                    </div>
                    <ul class="list" v-if="search == ''">
                      <li
                        class="clearfix"
                        v-for="(user, index) in activeusers"
                        :key="index"
                        @click="setActiveuser(user.id)"
                      >
                        <img
                          class="rounded-circle user-image"
                          :src="getImgUrl(user.thumb)"
                          alt=""
                        />
                        <div class="about">
                          <div class="name">{{ user.name }}</div>
                          <div class="status">{{ user.status }}</div>
                        </div>
                      </li>
                    </ul>
                    <ul class="list" v-if="search != ''">
                      <li
                        class="clearfix"
                        v-for="(user, index) in serchUser"
                        :key="index"
                        @click="setActiveuserSerch(user.id)"
                      >
                        <img
                          class="rounded-circle user-image"
                          :src="getImgUrl(user.thumb)"
                          alt=""
                        />
                        <div class="status-circle away"></div>
                        <div class="about">
                          <div class="name">{{ user.name }}</div>
                          <div class="status">{{ user.status }}</div>
                        </div>
                      </li>
                      <div v-if="!serchUser.length">
                        <div class="search-not-found chat-search text-center">
                          <div>
                            <p>
                              Böyle bir kullanıcı bulunamadı !
                            </p>
                          </div>
                        </div>
                      </div>
                    </ul>
                  </div>
                </div>
              </div>
            </div>
        </div>
                <div class="col chat-right-aside" style="margin-left:-30px">
                  <div class="chat">
                    <div class="chat-header clearfix">
                      <img
                        class="rounded-circle"
                        v-if="currentchat.thumb"
                        :src="getImgUrl(currentchat.thumb)"
                        alt=""
                      />
                      <div class="about">
                        <div class="name">
                          {{ currentchat.name}}
                        </div>
                        <div class="status digits">
                          {{ currentchat.lastSeenDate }}
                        </div>
                      </div>
                      <ul
                        class="list-inline float-left float-sm-right chat-menu-icons"
                      >
                        <li class="list-inline-item">
                          <a href="#"><i class="icon-search f-18" size="sm"></i></a>
                        </li>
                        <li class="list-inline-item">
                          <a href="#"><i class="icon-clip f-20"></i></a>
                        </li>
                        <li
                          class="list-inline-item toogle-bar"
                          v-on:click="chatmenutoogle = !chatmenutoogle"
                        >
                          <a href="#"><i class="icon-menu"></i></a>
                        </li>
                      </ul>
                    </div>
                    <div class="chat-history chat-msg-box custom-scrollbar m-t-30">
                      <ul>
                        <li
                          v-for="(chat, index) in currentChat.chat.messages"
                          :key="index"
                          v-bind:class="{ clearfix: chat.sender == 0 }"
                        >
                          <div
                            class="message shadow f-w-500"
                            v-bind:class="{
                              'other-message pull-right': chat.sender == 0,
                              'my-message': chat.sender != 0,
                            }"
                          >
                            <img
                              class="rounded-circle float-left chat-user-img img-30"
                              alt=""
                              v-if="currentchat.thumb && chat.sender != 0"
                              v-bind:src="getImgUrl(currentchat.thumb)"
                            />
                            <img
                              class="rounded-circle float-right chat-user-img img-30"
                              alt=""
                              v-if="chat.sender == 0"
                              v-bind:src="getImgUrl('user/5.jpg')"
                            />
                            <div
                              class="message-data"
                              v-bind:class="{ 'text-right': chat.sender == 0 }"
                            >
                              <small class="message-data-time f-w-300 txt-dark text-muted">{{
                                chat.time
                              }}</small>
                            </div>
                            {{ chat.text }}
                          </div>
                        </li>
                        <div v-if="!currentChat.chat.messages.length">
                          <div class="image-not-found">
                            <div class="d-block start-conversion">
                            </div>
                          </div>
                        </div>
                      </ul>
                    </div>
                    <div class="chat-message clearfix m-b-20">
                      <div class="row">
                        <div class="col-xl-12 d-flex">
                          <div class="input-group text-box">
                            <input
                              class="form-control input-txt-bx"
                              id="message-to-send"
                              v-model="text"
                              v-on:keyup.enter="addChat()"
                              type="text"
                              name="message-to-send"
                              placeholder="Mesaj giriniz..."
                            />
                            <div class="input-group-append">
                              <button
                                @click="addChat()"
                                class="btn btn-primary btn-"
                                type="button"
                              >
                                Gönder
                              </button>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { mapState } from "vuex";
export default {
  name: "Chat",
  data() {
    return {
      text: "",
      search: "",
      currentchat: [],
      chatmenutoogle: false,
    };
  },
  components: {},
  computed: {
    ...mapState({
      activeuser: (state) => state.chat.activeuser,
      users: (state) =>
        state.chat.users.filter(function (user) {
          if (user.id != 0) return user;
        }),
      serchUser: (state) => state.chat.serchUser,
      activeusers: (state) =>
        state.chat.users.filter(function (user) {
          if (user.active == "active" && user.id != 0) return user;
        }),
      chats: (state) =>
        state.chat.chats.find(function (chat) {
          if (chat.id == state.chat.activeuser) {
            return chat;
          }
        }),
      currentChat() {
        return (this.currentchat = this.$store.getters["chat/currentChat"]);
      },
    }),
  },
  mounted() {
    var container = this.$el.querySelector(".chat-history");
    container.scrollTop = container.scrollHeight;
  },
  methods: {
    getImgUrl(path) {
      return require("../../assets/images/" + path);
    },
    addChat: function () {
      if (this.text != "") {
        this.$store.dispatch("chat/addChat", this.text);
        this.text = "";
        var container = this.$el.querySelector(".chat-history");
        setTimeout(function () {
          container.scrollBy({ top: 200, behavior: "smooth" });
        }, 310);
        setTimeout(function () {
          container.scrollBy({ top: 200, behavior: "smooth" });
        }, 1100);
      }
    },
    setActiveuser: function (id) {
      this.$store.dispatch("chat/setActiveuser", id);
    },
    setActiveuserSerch: function (id) {
      this.$store.dispatch("chat/setActiveuser", id);
      this.search = "";
    },
    setSerchUsers: function () {
      if (this.search != "")
        this.$store.dispatch("chat/setSerchUsers", this.search);
    },
  },
};
</script>
