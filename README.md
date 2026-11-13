# 🪐 Space-CVT (Versão Legada)

> **⚠️ Aviso:** Este repositório contém o código-fonte de uma **versão antiga/legada** do projeto Space-CVT (`spacecvt-legacy`). Ele é mantido aqui para fins de histórico, versionamento e consulta.

O **Space-CVT** é uma plataforma de Realidade Virtual (RV) desenvolvida com o objetivo de apoiar o ensino e validar os conhecimentos de Astronomia e Astronáutica de crianças e adolescentes. O projeto foi concebido para atender os participantes das oficinas do projeto *Dia Astronômico*, realizado no **Centro Vocacional Tecnológico Espacial Augusto Severo (CVT-E)**, no Centro de Lançamento da Barreira do Inferno (CLBI).

---

## 🎓 Contexto Acadêmico

Este software foi desenvolvido originalmente em 2025 por **Danilo Lima Gomes** como requisito para a obtenção do título de Técnico em Informática pelo **Instituto Federal de Educação, Ciência e Tecnologia do Rio Grande do Norte (IFRN) - Campus Parnamirim**, sob a orientação do Prof. Me. Credson Isaac Lopes dos Santos.

O desenvolvimento adotou a abordagem de integração de habilidades **STEAM** (Ciências, Tecnologia, Engenharia, Artes e Matemática) e obteve sucesso em testes de campo em eventos como SBPC 2025, Space Week Nordeste (2024/2025) e SECITEX 2025, atendendo a mais de 1.700 usuários.

---

## 🎮 A Experiência (Gameplay)

A plataforma foi projetada para dispositivos de RV (com foco no **Meta Quest 3**) e é dividida estruturalmente em duas fases principais:

1. **Simulação do CVT-E (Fase 1):** O jogador inicia em uma recriação tridimensional das instalações físicas do Centro Vocacional Tecnológico Espacial. Esta fase serve como uma ambientação, permitindo que o público externo tenha uma amostra virtual do espaço físico real do projeto.
2. **Exploração Espacial e Validação (Fase 2):** O jogador é transportado para um ambiente imersivo no espaço. Aqui, ele pode explorar o sistema solar e visualizar informações detalhadas dos planetas.
   * **Dinâmica de Perguntas:** O usuário deve responder a perguntas interativas sobre os corpos celestes.
   * **Dados em Tempo Real:** As informações dos planetas e as respostas corretas das perguntas são atualizadas em tempo real com base em dados astronômicos reais.

---

## ⚙️ Principais Mecânicas e Tecnologias

O projeto interliga diversas áreas da computação, desde modelagem 3D até redes e banco de dados:

* **Motor Gráfico & Programação:** Desenvolvido na **Unity** utilizando a linguagem **C#** (com scripts editados via Visual Studio Code).
* **Modelagem 3D:** Os ambientes, incluindo os hangares do CVT-E, foram modelados e texturizados de forma autoral utilizando o **Blender**.
* **Integração de Dados Astronômicos (API):** Consumo de dados via requisições web à API local do software **Stellarium**. Isso garante que a posição, luminosidade e atributos dos planetas sejam fidedignos ao momento em que o usuário joga.
* **Persistência de Dados e Gamificação:** O jogo possui um sistema de pontuação. Ao final da experiência, o *score*, nome e tempo do usuário são enviados via requisições HTTP para uma API em **PHP**, que registra os resultados em um banco de dados **MySQL** (gerenciado via **XAMPP/phpMyAdmin**).

---

## 📂 Estrutura do Repositório

Neste repositório antigo, você encontrará:
- O código-fonte principal dos scripts na Unity (C#).
- Os *assets* e modelos 3D originais utilizados na época.
- Os arquivos PHP de conexão com o banco de dados (`ServerConnection.php` e `ServerSendConnection.php`).
- Documentações auxiliares (como o Game Design Document - GDD).
