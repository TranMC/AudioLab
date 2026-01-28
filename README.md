# 🎵 AudioLab - Báo Cáo Thực Hành Chương 4: Audio & Video (Unity)

## 📌 Giới Thiệu
Dự án thực hành toàn diện về **Audio** và **Video** trong Unity, bao gồm **7 bài Lab** và **1 Mini Project**. Giúp nắm vững cách sử dụng `AudioSource`, `VideoPlayer`, `RenderTexture` và các công cụ audio-video của Unity.

**Trạng thái:** Hoàn thành

---

## 📚 Mục Lục
1. [Lab 1 - Sound Trigger](#-lab-1--audiosource-cơ-bản-sound-trigger)
2. [Lab 2 - Audio 2D vs 3D](#-lab-2--audio-2d-vs-3d-spatial-audio)
3. [Lab 3 - Master Volume Control](#-lab-3--điều-khiển-âm-thanh-toàn-cục-audiolistener)
4. [Lab 4 - Audio Optimization](#-lab-4--audioclip-import--optimization)
5. [Lab 5 - Video Playback](#-lab-5--videoplayer-cơ-bản)
6. [Lab 6 - Video Render Target](#-lab-6--video-render-target)
7. [Lab 7 - Video Events](#-lab-7--video-events--control)
8. [Mini Project - Intro Cutscene](#-mini-project--intro-cutscene-game)

---

## 🎯 Lab 1 – AudioSource Cơ Bản (Sound Trigger)

**🎮 Điều khiển:**
- `SPACE` → Phát âm thanh
- `S` → Dừng âm thanh

| Thông tin | Chi tiết |
|-----------|---------|
| **Mục tiêu** | Hiểu cách sử dụng AudioSource và điều khiển âm thanh qua code |
| **Kết quả** | ✅ Âm thanh phát/dừng chính xác, không tự động phát lúc load |
| **Kiến thức** | AudioSource, Play(), Stop() |
| **Video** | [text](https://github.com/user-attachments/assets/30d96567-ada5-47a3-86f9-97bf33966678) |

---

## 🎶 Lab 2 – Audio 2D vs 3D (Spatial Audio)

**🎮 Hiểu rõ:** Spatial Blend để so sánh âm thanh 2D và 3D trong không gian 3D

| Âm thanh 2D | Âm thanh 3D |
|------------|-----------|
| 🔊 Âm lượng không đổi | 🔉 Giảm theo khoảng cách |
| 📻 Dùng cho nhạc nền, UI | 🌍 Dùng cho âm thanh môi trường |
| Không phụ thuộc vị trí | Thay đổi theo hướng |

| Thông tin | Chi tiết |
|-----------|---------|
| **Kết quả** | ✅ Âm thanh 2D/3D hoạt động đúng theo khoảng cách |
| **Kiến thức** | Spatial Blend, AudioListener, 3D positioning |
| **Video** | [▶️ Xem video](https://github.com/user-attachments/assets/6d9fa92f-238e-4610-bc20-32e7a6cbdddf) |

---

## 🔊 Lab 3 – Điều Khiển Âm Thanh Toàn Cục (AudioListener)

**🎮 Điều khiển:**
- `M` → Tắt/Mở toàn bộ âm thanh
- `P` → Pause/Resume âm thanh

| Thông tin | Chi tiết |
|-----------|---------|
| **Mục tiêu** | Kiểm soát âm thanh toàn cục qua AudioListener |
| **Kết quả** | ✅ Master volume và pause hoạt động chính xác |
| **Kiến thức** | AudioListener.volume, Time.timeScale |
| **Video** | [▶️ Xem video](https://github.com/user-attachments/assets/13587ce9-7de7-420b-9610-434308ddf58e) |

---

## 📦 Lab 4 – AudioClip Import & Optimization

**Cấu hình AudioClip theo loại:**

| BGM (Background Music) | SFX (Sound Effects) |
|----------------------|-------------------|
| **Load Type:** Streaming | **Load Type:** Decompress On Load |
| **Compression:** Vorbis | **Compression:** ADPCM / PCM |
| 💾 Tiết kiệm bộ nhớ | ⚡ Phản hồi nhanh |
| 🎵 Phát ổn định | 🎯 Chính xác timing |

| Thông tin | Chi tiết |
|-----------|---------|
| **Mục tiêu** | Tối ưu hiệu năng audio |
| **Kết quả** | ✅ BGM/SFX được cấu hình tối ưu |
| **Kiến thức** | AudioClip settings, Load Type, Compression |
| **Video** | [▶️ Xem video](https://github.com/user-attachments/assets/7fcd7d09-ecc4-4d39-b8b3-e6c561c2dc29) |

---

## 🎬 Lab 5 – VideoPlayer Cơ Bản

**Mục tiêu:** Import video mp4 và phát qua VideoPlayer

| Thông tin | Chi tiết |
|-----------|---------|
| **Mô tả** | Sử dụng VideoPlayer component phát video trong scene |
| **Kết quả** | ✅ Video phát đúng, không lỗi hình ảnh/âm thanh |
| **Kiến thức** | VideoPlayer, Play(), Pause() |
| **Video** | [▶️ Xem video](https://github.com/user-attachments/assets/38ea279a-9a72-45fc-af6f-78d7a0684243) |

---

## 🖼️ Lab 6 – Video Render Target

**Quy trình:** VideoPlayer → RenderTexture → RawImage (UI Canvas)

```
[VideoPlayer] 
    ↓
[RenderTexture] 
    ↓
[RawImage on Canvas]
```

| Thông tin | Chi tiết |
|-----------|---------|
| **Mục tiêu** | Hiển thị video trên UI |
| **Ứng dụng** | Màn hình TV, Intro cutscene, Video trên đối tượng 3D |
| **Kết quả** | ✅ Video hiển thị đúng trên UI |
| **Kiến thức** | RenderTexture, VideoPlayer target texture |
| **Video** | [▶️ Xem video](https://github.com/user-attachments/assets/f8b992d4-767e-4601-b46a-e399e6db10a8) |

---

## 🎬 Lab 7 – Video Events & Control

**Events sử dụng:**
- `prepareCompleted` → Tự động phát khi video sẵn sàng
- `loopPointReached` → Xử lý khi video kết thúc

| Thông tin | Chi tiết |
|-----------|---------|
| **Mục tiêu** | Kiểm soát video bằng event |
| **Kết quả** | ✅ Video được kiểm soát hoàn toàn bằng event |
| **Kiến thức** | VideoPlayer events, event callbacks |
| **Video** | [▶️ Xem video](https://github.com/user-attachments/assets/934e470e-a131-4870-8207-6af822fe7152) |

---

## 🎮 Mini Project – Intro Cutscene Game

**Tính năng:**
- 🎬 Video intro + nhạc nền đồng bộ
- ⏭️ Nút Skip bỏ qua intro
- 🎯 Tự động chuyển sang gameplay sau video
- 📊 Hiển thị video qua RenderTexture

| Thông tin | Chi tiết |
|-----------|---------|
| **Mục tiêu** | Tổng hợp kiến thức Audio & Video |
| **Kết quả** | ✅ Intro mượt, không lỗi, Skip hoạt động, load gameplay chính xác |
| **Kiến thức** | Kết hợp toàn bộ kiến thức từ Lab 1-7 |
| **Video** | [▶️ Xem video](https://github.com/user-attachments/assets/680851db-18ef-46c9-9efe-b8603ef72801) |

---

## 🛠️ Công Nghệ & Công Cụ

| Loại | Chi tiết |
|------|---------|
| **Engine** | Unity |
| **Language** | C# |
| **Audio** | AudioSource, AudioListener, AudioClip |
| **Video** | VideoPlayer, RenderTexture |
| **UI** | RawImage, Canvas |

---

## 📁 Cấu Trúc Thư Mục

```
Assets/
├── Scenes/           (7 Lab scenes + 1 Mini Project scene)
│   ├── Lab1.unity
│   ├── Lab2.unity
│   ├── Lab3.unity
│   ├── Lab4.unity
│   ├── Lab5.unity
│   ├── Lab6.unity
│   ├── Lab7.unity
│   └── MiniProject.unity
├── Scripts/          (C# controllers)
│   └── IntroCutsceneController.cs
├── Audio/            (BGM & SFX)
│   ├── BGM/
│   └── SFX/
└── Video/            (Video files & RenderTextures)
```

---

## ✨ Ghi Chú
- 🎯 Mỗi lab xây dựng nên kiến thức cơ bản từ dễ đến khó
- 🎮 Mọi tính năng điều khiển bằng bàn phím để dễ test
- 🎬 Mini project là ứng dụng thực tế của toàn bộ kiến thức
- 📊 Sử dụng RenderTexture để tối ưu hiệu năng video
