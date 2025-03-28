<lane orientation="vertical" 
    horizontal-content-alignment="middle">
    <banner background={@Mods/StardewUI/Sprites/BannerBackground}
            background-border-thickness="48,0"
            padding="12"
            text={HeaderText} />
    <frame layout="440px 880px"
           margin="0,16,0,0"
           padding="32,24"
           background={@Mods/StardewUI/Sprites/ControlBorder}>
        <scrollable peeking="128">
            <grid layout="stretch content"
                  item-layout="length: 64"
                  item-spacing="16,16"
                  horizontal-item-alignment="middle">
                <image *repeat={Items}
                       layout="stretch content"
                       sprite={this}
                       tooltip={DisplayName}
                       focusable="true" />
            </grid>
        </scrollable>
    </frame>
</lane>