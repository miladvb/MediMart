import type { Metadata } from "next";

import "./globals.css";
import Navbar from "./Layout/Navbar";
import { f_NNA } from "./libs/fonts";

export const metadata: Metadata = {
  title: "داروجو",
  description: "داروجو - جستجوی هوشمند داروها",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="fa" dir="rtl">
      <body className={`${f_NNA.className} bg-gray-50 `}>
        <Navbar />
        {children}
      </body>
    </html>
  );
}

