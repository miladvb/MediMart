import {
  Vazirmatn,
  Oi,
  Beiruti,
  Alexandria,
  El_Messiri,
  Changa,
  Noto_Naskh_Arabic,
} from "next/font/google";

const f_NNA = Noto_Naskh_Arabic({
  variable: "--font-Noto_Naskh_Arabic",
  weight: ["400", "500", "600", "700"],
  display: "swap", //  بهینه برای لود سریع‌تر فونت
});

const f_Vazirmatn = Vazirmatn({
  variable: "--font-Vazirmatn",
  weight: ["100", "200", "300", "400", "500", "600", "700", "800", "900"],
  display: "swap", //  بهینه برای لود سریع‌تر فونت
});

const f_Alexandria = Alexandria({
  variable: "--font-alexandria",
  weight: ["100", "200", "300", "400", "500", "600", "700", "800", "900"],
  display: "swap", //  بهینه برای لود سریع‌تر فونت
});

const f_oi = Oi({
  variable: "--font-oi",
  weight: "400",
  display: "swap", //  بهینه برای لود سریع‌تر فونت
});

const f_Beiruti = Beiruti({
  variable: "--font-Beiruti",
  weight: ["200", "300", "400", "500", "600", "700", "800", "900"],
  display: "swap", //  بهینه برای لود سریع‌تر فونت
});

const f_El_Messiri = El_Messiri({
  variable: "--font-El_Messiri",
  weight: ["400", "500", "600", "700"],
  display: "swap", //  بهینه برای لود سریع‌تر فونت
});

const f_Changa = Changa({
  variable: "--font-Beiruti",
  weight: ["200", "300", "400", "500", "600", "700", "800"],
  display: "swap", //  بهینه برای لود سریع‌تر فونت
});

export { f_Changa, f_El_Messiri, f_Alexandria, f_Beiruti, f_oi, f_Vazirmatn, f_NNA };
